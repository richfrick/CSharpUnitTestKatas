using Math = CSharpUnitTestKatas.Fundamentals.Math;

namespace CSharpUnitTestKatas.UnitTests.Fundamentals;

[TestFixture]
public class MathTests
{
    private Math _math;

    //Example of using setup
    [SetUp]
    public void SetUp()
    {
        _math = new Math();
    }
    
    //Some basic Unit tests
    [Test]
    public void Add_WhenCalled_ReturnsSumOfArguments()
    {
        var result = _math.Add(1, 2);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Max_SecondArgumentIsGreater_ReturnsSecondArgument()
    {
        var result = _math.Max(1, 2);
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Max_FirstArgumentIsGreater_ReturnsFirstArgument()
    {
        var result = _math.Max(2, 1);
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void Max_ArgumentsAreEqual_ReturnsTheSameValue()
    {
        var result = _math.Max(1, 1);
        Assert.That(result, Is.EqualTo(1));
    }
    
    //parameterised tests (This is an example of how you can replace the 3 tests for the Max method with one)
    [Test]
    [TestCase(1, 2, 2)]
    [TestCase(2, 1, 2)]
    [TestCase(1, 1, 1)]
    public void Max_WhenCalled_ReturnsTheGreaterArgument(int a, int b, int c)
    {
        var result = _math.Max(a, b);
        Assert.That(result, Is.EqualTo(c));
    }
    
}