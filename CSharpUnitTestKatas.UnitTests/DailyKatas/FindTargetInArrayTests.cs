namespace CSharpUnitTestKatas.UnitTests;

[TestFixture]
public class FindTargetInArrayTests
{
    [Test]
    public void TwoSum_MatchesTwoNumbers_ReturnsArray()
    {
        var dailyKata = new CamelCase();
        var result = FindTargetInArray.TwoSum(new[] { 1, 2, 3 }, 4);
        Assert.That(result, Is.EqualTo(new[]{0,2}));
    }
    
    public void TwoSum_MatchesTwoNumbers1_ReturnsArray()
    {
        var dailyKata = new CamelCase();
        var result = FindTargetInArray.TwoSum(new[] { 1234, 5678, 9012 }, 14690);
        Assert.That(result, Is.EqualTo(new[]{1,2}));
    }
    
    public void TwoSum_MatchesTwoNumbers2_ReturnsArray()
    {
        var dailyKata = new CamelCase();
        var result = FindTargetInArray.TwoSum(new[] { 2, 2, 3 }, 4);
        Assert.That(result, Is.EqualTo(new[]{0,1}));
    }
}