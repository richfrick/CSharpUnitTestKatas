using CSharpUnitTestKatas.Fundamentals;

namespace CSharpUnitTestKatas.UnitTests.Fundamentals;

[TestFixture]
public class DetermitPointsCalculatorTests
{
    [Test]
    public void CalculateDemeritPoints_SpeedIsNegative_ReturnsException()
    {
        var calculator = new DetermitPointsCalculator();
        Assert.That(()=> calculator.CalculateDemeritPoints(-1),
        Throws.Exception);
    }
    
    [Test]
    [TestCase(-1)]
    [TestCase(301)]
    public void CalculateDemeritPoints_SpeedOutOfRange_ThrowsArgumentOutOfRangeException(int speed)
    {
        var calculator = new DetermitPointsCalculator();
        Assert.That(()=> calculator.CalculateDemeritPoints(speed),
        Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
    }
    
    [Test]
    [TestCase(0, 0)]
    [TestCase(50, 0)]
    [TestCase(65, 0)]
    [TestCase(66, 0)]
    [TestCase(70, 1)]
    [TestCase(75, 2)]
    public void CalculateDemeritPoints_WhenCalled_ReturnsDemeritPoints(int speedLimit, int points)
    {
        var calculator = new DetermitPointsCalculator();
        var result = calculator.CalculateDemeritPoints(speedLimit);
        Assert.That(result, Is.EqualTo(points));
    }
}