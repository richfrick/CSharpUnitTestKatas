using System.Net;
using CSharpUnitTestKatas.InstallerHelper;
using Moq;

namespace CSharpUnitTestKatas.UnitTests.InstallerHelper;

[TestFixture]
public class InstallerHelperTests
{
    private Mock<IFileDownloader> _fileDownloader;
    private CSharpUnitTestKatas.InstallerHelper.InstallerHelper _installerHelper;

    [SetUp]
    public void setup()
    {
        _fileDownloader = new Mock<IFileDownloader>();
        _installerHelper = new CSharpUnitTestKatas.InstallerHelper.InstallerHelper(_fileDownloader.Object);
    }

    [Test]
    public void DownloadInstaller_DownloadFails_ReturnFalse()
    {
        _fileDownloader.Setup(fd => fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>())).Throws<WebException>();

        var result = _installerHelper.DownloadInstaller("customer", "installer");
        
            Assert.That(result, Is.False);
    }
    
    [Test]
    public void DownloadInstaller_DownloadComplete_ReturnTrue()
    {
        var result = _installerHelper.DownloadInstaller("customer", "installer");
        
        Assert.That(result, Is.True);
    }

}