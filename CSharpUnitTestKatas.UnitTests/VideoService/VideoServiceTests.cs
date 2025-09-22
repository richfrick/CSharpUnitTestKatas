using CSharpUnitTestKatas.VideoService;
using Moq;

[TestFixture]
public class VideoServiceTests
{
    private Mock<IFileReader> _fileReader;
    private VideoService _videoService;

    [SetUp]
    public void Setup()
    {
        _fileReader = new Mock<IFileReader>();
        _videoService = new VideoService(_fileReader.Object);
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
}