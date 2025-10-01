using CSharpUnitTestKatas.DailyKatas;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas;

[TestFixture]
public class BeginnerKataTests
{
    [TestFixture]
    public class ShortenDates
    {
        [Test]
        [TestCase("Friday May 2, 9am", "Friday May 2")]

        [TestCase("Tuesday January 29, 10pm", "Tuesday January 29")]
        public void ShortenToDate_WithValidFormat_RemovesTime(string longDate, string shortDate)
        {
            var result = BeginnerKatas.ShortenToDate(longDate);
            Assert.That(result, Is.EqualTo(shortDate));
        }

        [Test]
        public void ShortenToDate_WithInvalidFormat_RemovesTime()
        {
            var result = BeginnerKatas.ShortenToDate("Friday May 2");
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
            var result = BeginnerKatas.SpeakEnglish(sentence);
            Assert.That(result, Is.EqualTo(res));
        }
        
    }
    
    [TestFixture]
    public class AreaOrPerimeter()
    {
        [Test]
        [TestCase(4,4,16)]
        [TestCase(6,10,32)]
        public void AreaOrPerimeter_WhePassedValidValues_ReturnsAreaOrPerimeter(int length, int width, int areaOrPerimeter)
        {
            var result = BeginnerKatas.AreaOrPerimeter(length, width);
            Assert.That(result, Is.EqualTo(areaOrPerimeter));
        }
    }
}