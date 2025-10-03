using CSharpUnitTestKatas.DailyKatas.MathOperator;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas.MathOperatorTests;

[TestFixture]
public class MathOperatorTests
{
    [TestFixture]
    public class AreaOrPerimeter()
    {
        [Test]
        [TestCase(4,4,16)]
        [TestCase(6,10,32)]
        public void AreaOrPerimeter_WhePassedValidValues_ReturnsAreaOrPerimeter(int length, int width, int areaOrPerimeter)
        {
            var result = MathOperator.AreaOrPerimeter(length, width);
            Assert.That(result, Is.EqualTo(areaOrPerimeter));
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
            var result = MathOperator.TimeStamp(timeInsecs);
            Assert.That(result, Is.EqualTo(time));
        }
        
        [Test]
        public void TimeStamp_WhenPassedTheTimeGreaterThan35999_Uses359999asDefault()
        {
            var result = MathOperator.TimeStamp(500000);
            Assert.That(result, Is.EqualTo("99:59:59"));
        }
    }
    
    [TestFixture]
    public class BetterThanAverage()
    {
        [Test]
        public void BetterThanAverage_WhenYourScoreIsGreaterThanAverage_ReturnsTrue()
        {
            var result = MathOperator.BetterThanAverage(new[]{1,2,3}, 5);
            Assert.That(result, Is.True);
        }
        [Test]
        public void BetterThanAverage_WhenYourScoreIsLessThanAverage_ReturnsFalse()
        {
            var result = MathOperator.BetterThanAverage(new[]{1,2,3}, 1);
            Assert.That(result, Is.False);
        }
    }
}