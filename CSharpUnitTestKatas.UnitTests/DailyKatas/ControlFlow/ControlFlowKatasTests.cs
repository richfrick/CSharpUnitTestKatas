using CSharpUnitTestKatas.DailyKatas.ControlFlow;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas.ControlFlow;

[TestFixture]
public class ControlFlowKatasTests
{
    [Test]
    [TestCase(2, 'F')]
    [TestCase(0.9, 'A')]
    [TestCase(0.7, 'C')]
    [TestCase(0.6, 'D')]
    public void Grader_WhenPassedAScore_ReturnsAGrade(double input, char output)
    {
        var result = ControlFlowKatas.Grader(input);
        Assert.That(result, Is.EqualTo(output));
    }
    
}