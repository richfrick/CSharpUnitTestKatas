using CSharpUnitTestKatas.DailyKatas.MathOperator;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas.MathOperatorTests;

[TestFixture]
public class ProbabilityTests
{
    private const double Delta = 0.0000001;
    [Test]
    [TestCase((uint)5,(uint)5,(uint)2,(uint)3, 0.6)]
    [TestCase((uint)5,(uint)7,(uint)4,(uint)3, 0.2)]
    [TestCase((uint)12,(uint)18,(uint)4,(uint)6, 0.4)]
    public void GuessBlue_WithValidNumbers_ReturnsProbability(uint blueStart, uint redStart, uint bluePulled, uint redPulled, double output)
    {
        var result = Probability.GuessBlue(blueStart, redStart, bluePulled, redPulled);
        Assert.That(result, Is.EqualTo(output).Within(Delta));
    }
    
}