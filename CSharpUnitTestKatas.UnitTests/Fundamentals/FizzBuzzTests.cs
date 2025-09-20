using CSharpUnitTestKatas.Fundamentals;

namespace CSharpUnitTestKatas.UnitTests.Fundamentals;

[TestFixture]
public class FizzBuzzTests
{
    [Test]
    public void GetOutput_DivisibleByThreeAndFive_ReturnsFizzBuzz()
    {
        var result = FizzBuzz.GetOutput(15);
        Assert.That(result, Is.EqualTo("FizzBuzz"));   

    }

    [Test]
    public void etOutput_DivisibleByThree_ReturnsFizz()
    {
        var result = FizzBuzz.GetOutput(6);
        Assert.That(result, Is.EqualTo("Fizz"));
    }
    
    [Test]
    public void etOutput_DivisibleByFive_ReturnsBuzz()
    {
        var result = FizzBuzz.GetOutput(10);
        Assert.That(result, Is.EqualTo("Buzz"));  
    }
    
    [Test]
    public void GetOutput_NotDivisibleByThreeAndFive_ReturnsNumberAsString()
    {
        var result = FizzBuzz.GetOutput(7);
        Assert.That(result, Is.EqualTo("7"));  
    }
    
}