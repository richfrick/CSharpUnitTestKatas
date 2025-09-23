using CSharpUnitTestKatas.VideoService;
using Moq;

[TestFixture]
public class VideoServiceTests
{
    private Mock<IFileReader> _fileReader;
    private VideoService _videoService;
    private Mock<IVideoRepository> _repository;

    [SetUp]
    public void Setup()
    {
        _fileReader = new Mock<IFileReader>();
        _repository = new Mock<IVideoRepository>();
        _videoService = new VideoService(_fileReader.Object, _repository.Object);
    }
    
    [Test]
    public void ReadVideoTitle_FileReaderIsNull_ReturnsError()
    {
        _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
        var result = _videoService.ReadVideoTitle();
        Assert.That(result, Does.Contain("error").IgnoreCase);
    }

    [Test]
    public void ReadVideoTitle_FileReaderReturnsFileContents_TitleWillBeInception()
    {
        _fileReader.Setup(fr => fr.Read("video.txt")).Returns("{ \"Title\": \"Inception\" }");
        var result = _videoService.ReadVideoTitle();
        Assert.That(result, Is.EqualTo("inception").IgnoreCase);
    }

    [Test]
    public void GetUnprocessedVideosAsCsv_NoUnprocessedVideos_ReturnAnEmptyString()
    {
        _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<VideoService.Video>());
        var result = _videoService.GetUnprocessedVideosAsCsv();
        
        Assert.That(result, Is.EqualTo(""));
    }
    
    [Test]
    public void GetUnprocessedVideosAsCsv_SomeUnprocessedVideos_ReturnsListOfIds()
    {
        _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<VideoService.Video>
        {
            new VideoService.Video {Id = 1},
            new VideoService.Video {Id = 2},
            new VideoService.Video {Id = 3},
        });
        var result = _videoService.GetUnprocessedVideosAsCsv();
        
        Assert.That(result, Is.EqualTo("1,2,3"));
    }
}