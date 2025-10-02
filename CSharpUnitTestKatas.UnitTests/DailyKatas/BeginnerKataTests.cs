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

    [TestFixture]
    public class RemoveEveryOther()
    {
        [Test]
        public void RemoveEveryOther_WhenPassedStringArray_RemovesEverySecondElement()
        {
            var input = new[] { "keep", "remove", "keep", "remove" };
            var result = BeginnerKatas.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new []{"keep", "keep"}));
        }
        
        [Test]
        public void RemoveEveryOther_WhenPassedNestedArray_RemovesEverySecondElement()
        {
            var input = new object[] { new object[] { 1, 2 } };
            var result = BeginnerKatas.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new object[] { new object[] { 1, 2 } }));
        }
        
        [Test]
        public void RemoveEveryOther_WhenPassedIntArray_RemovesEverySecondElement()
        {
            var input = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = BeginnerKatas.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new object[]{ 1, 3, 5, 7, 9 }));
        }
        
        [Test]
        public void RemoveEveryOther_WhenPassedNestedObjects_RemovesEverySecondElement()
        {
            var input = new object[] { new object[] { "Goodbye" }, new Dictionary<string,string>(){{"Great", "Job"}}};
            var result = BeginnerKatas.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new object[] { new object[] { "Goodbye" } }));
        }
        
        [Test]
        public void RemoveEveryOther_WhenPassedEmptyArray_RemovesEverySecondElement()
        {
            var input = new object[] { };
            var result = BeginnerKatas.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new object[] { }));
        }
    }

    [TestFixture]
    public class GetUnique
    {
        [Test]
        [TestCase(new [] { 1,2,2,2 }, 1)]
        [TestCase(new [] { -2,2,2,2 }, -2)]
        [TestCase(new [] { 11,11,14,11,11 }, 14)]
        public void GetUnique_WhenPassedList_ReturnsTheUniquesNumber(IEnumerable<int> ip, int res )
        {
            var result = BeginnerKatas.GetUniqueRefactor(ip);
            Assert.That(result, Is.EqualTo(res));    
        }
    }

    [TestFixture]
    public class TimeStamp
    {
        [Test]
        [TestCase(0, "00:00:00")]
        [TestCase(59, "00:00:59")]
        [TestCase(60, "00:01:00")]
        [TestCase(90, "00:01:30")]
        [TestCase(3599, "00:59:59")]
        [TestCase(3600, "01:00:00")]
        [TestCase(45296, "12:34:56")]
        [TestCase(86399, "23:59:59")]
        [TestCase(86400, "24:00:00")]
        [TestCase(359999, "99:59:59")]
        public void TimeStamp_WhenPassedTheTimeInMinutes_ReturnsHHMMSS(int timeInsecs, string time)
        {
            var result = BeginnerKatas.TimeStamp(timeInsecs);
            Assert.That(result, Is.EqualTo(time));
        }
        
        [Test]
        public void TimeStamp_WhenPassedTheTimeGreaterThan35999_Uses359999asDefault()
        {
            var result = BeginnerKatas.TimeStamp(500000);
            Assert.That(result, Is.EqualTo("99:59:59"));
        }
    }
    
    [TestFixture]
    public class BetterThanAverage()
    {
        [Test]
        public void BetterThanAverage_WhenYourScoreIsGreaterThanAverage_ReturnsTrue()
        {
            var result = BeginnerKatas.BetterThanAverage(new[]{1,2,3}, 5);
            Assert.That(result, Is.True);
        }
        [Test]
        public void BetterThanAverage_WhenYourScoreIsLessThanAverage_ReturnsFalse()
        {
            var result = BeginnerKatas.BetterThanAverage(new[]{1,2,3}, 1);
            Assert.That(result, Is.False);
        }
    }
    
    [TestFixture]
    public class Digitize
    {
        [Test]
        [TestCase(35231, new long[]{1,3,2,5,3})]
        [TestCase(0, new long[]{0})]
        public void Digitize_test(long input, long[] output)
        {
            var result = BeginnerKatas.Digitizer(input);
            Assert.That(result, Is.EqualTo(output));
        }
    }

    [TestFixture]
    public class Array
    {
        [Test]
        [TestCase("", null)]
        [TestCase("1", null)]
        [TestCase("1,2", null)]
        [TestCase("1, 3",null)]
        [TestCase("1,2,3", "2")]
        [TestCase("1,2,3, 4", "2 3")]
        public void Array_ArrayWithMoreThan2CommaSeparatedChars_ReturnsNewString(string input, string? output)
        {
            var result = BeginnerKatas.Array(input);
            Assert.That(result, Is.EqualTo(output));
        }
    }
}