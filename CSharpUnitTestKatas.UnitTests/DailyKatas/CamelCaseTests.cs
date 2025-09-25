namespace CSharpUnitTestKatas.UnitTests;

[TestFixture]
public class CamelCaseTests
{
    
    [Test]
    public void BreakCamelCase_StringWithNoCapitals_ReturnsSameString()
    {
        var dailyKata = new CamelCase();
        var result = dailyKata.BreakCamelCase("foo");
        Assert.That(result, Is.EqualTo("foo"));

    }
    [Test]
    public void BreakCamelCase_StringWithSingleCapitalLetter_ReturnsSplitString()
    {
        var dailyKata = new CamelCase();
        var result = dailyKata.BreakCamelCase("fooBar");
        Assert.That(result, Is.EqualTo("foo Bar"));
    }
    [Test]
    public void BreakCamelCase_StringWithMultipleCapitalLetters_ReturnsSplitString()
    {
        var dailyKata = new CamelCase();
        var result = dailyKata.BreakCamelCase("fooBarFooBar");
        Assert.That(result, Is.EqualTo("foo Bar Foo Bar"));
    }
}