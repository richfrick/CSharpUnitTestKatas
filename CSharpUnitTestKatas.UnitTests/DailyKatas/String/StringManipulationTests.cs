using CSharpUnitTestKatas.DailyKatas.String;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas.String;

[TestFixture]
public class StringManipulationTests
{
    [TestFixture]
    public class ShortenDates
    {
        [Test]
        [TestCase("Friday May 2, 9am", "Friday May 2")]

        [TestCase("Tuesday January 29, 10pm", "Tuesday January 29")]
        public void ShortenToDate_WithValidFormat_RemovesTime(string longDate, string shortDate)
        {
            var result = StringManipulation.ShortenToDate(longDate);
            Assert.That(result, Is.EqualTo(shortDate));
        }

        [Test]
        public void ShortenToDate_WithInvalidFormat_RemovesTime()
        {
            var result = StringManipulation.ShortenToDate("Friday May 2");
            Assert.That(result, Is.EqualTo("Friday May 2"));
        }
    }
    
    [TestFixture]
    public class SpeakEnglish
    {
        [Test]
        [TestCase("hello world", false)]
        [TestCase("egnlish", false)]
        [TestCase("", false)]
        [TestCase("english", true)]
        [TestCase("1234english ;k", true)]
        [TestCase("I speak English", true)]
        [TestCase("ABC123DOREME", false)]
        [TestCase("eNgliSh", true)]
        [TestCase("1234#$%%eNglish ;k9", true)]
        [TestCase("spanish, english, french", true)]
        [TestCase("englishENGLISHEnGlISHENglisH", true)]
        [TestCase("HeLlO tHeR3 enGLiSh MuffIN", true)]
        public void SpeakEnglish_WhenPassedString_ReturnsBool(string sentence, bool res)
        {
            var result = StringManipulation.SpeakEnglish(sentence);
            Assert.That(result, Is.EqualTo(res));
        }
    }
    
    [TestFixture]
    public class ValidateHello()
    {
        [Test]
        [TestCase("hiya, Hello", true)]
        [TestCase("ciao bella!", true)]
        [TestCase("salut", true)]
        [TestCase("hallo salut", true)]
        [TestCase("hombre!! hola", true)]
        [TestCase("Hallo, wie geht's dir?", true)]
        [TestCase("AHOJ!", true)]
        [TestCase("czesc", true)]
        [TestCase("Ahoj", true)]
        [TestCase("mah", false)]
        public void ValidateHello_PassValidGreeting_ReturnsLanguage(string greeting, bool isFound)
        {
            var result = StringManipulation.ValidateHello(greeting);
            Assert.That(result, Is.EqualTo(isFound));
        }
    }

    [TestFixture]
    public class BandNameGenerator
    {
        [Test]
        [TestCase("alaska", "Alaskalaska")]
        [TestCase("darkness", "The Darkness")]
        public void BandNameGenerator_WhenSuppliedName_ReturnsTheNewBandName(string noun, string bandName)
        {
            var result = StringManipulation.BandNameGenerator(noun);
            Assert.That(result, Is.EqualTo(bandName));
        }
    }
}