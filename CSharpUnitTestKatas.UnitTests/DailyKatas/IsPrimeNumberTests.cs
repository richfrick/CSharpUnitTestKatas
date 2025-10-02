using CSharpUnitTestKatas.DailyKatas;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas;

[TestFixture]
public class IsPrimeNumberTests
{
    [Test]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(11)]
    [TestCase(17)]
    [TestCase(23)]
    [TestCase(31)]
    [TestCase(41)]
    [TestCase(61)]
    public void IsPrimeNumberSolution_IsPrimeNumber_ReturnsTrue(int num)
    {
        var result = IsPrimeNumber.isPrimeNumberSolutionRefactor(num);
        Assert.That(result, Is.True);
    }
    
    [Test]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(4)]
    [TestCase(6)]
    [TestCase(8)]
    [TestCase(9)]
    [TestCase(10)]
    public void IsPrimeNumberSolution_IsNotPrimeNumber_ReturnsFalse(int num)
    {
        var result = IsPrimeNumber.isPrimeNumberSolutionRefactor(num);
        Assert.That(result, Is.False);
    }
}