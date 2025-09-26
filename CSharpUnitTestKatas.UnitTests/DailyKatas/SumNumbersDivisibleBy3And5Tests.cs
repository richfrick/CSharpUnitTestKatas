namespace CSharpUnitTestKatas.UnitTests;

[TestFixture]
public class SumNumbersDivisibleBy3And5Tests
{
    [Test]
    [TestCase(10, 23)]
    [TestCase(20, 78)]
    [TestCase(200, 9168)]
    [TestCase(0, 0)]
    public void Solution_Input10_Reuslt23(int input, int sum)
    {
        var result = SumNumbersDivisibleBy3And5.Solution(input);
        Assert.That(result, Is.EqualTo(sum));
    }
}