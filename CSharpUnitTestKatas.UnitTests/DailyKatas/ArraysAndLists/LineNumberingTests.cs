using CSharpUnitTestKatas.DailyKatas.ArraysAndLists;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas.ArraysAndLists;

[TestFixture]
public class LineNumberingTests
{
    [Test]
    public void LineNumbering_EmptyArray_ReturnsEmptyArray()
    { 
        var input = new List<string>{}; 
        var result = LineNumbering.Number(input); 
        Assert.That(result, Is.EqualTo(new List<string>(){}));
    }
    
    [Test]
    public void LineNumbering_ArrayWithCharacters_ReturnsArrayWithLineNumbers()
    {
        var input = new List<string> { "a", "b", "c" }; 
        var result = LineNumbering.Number(input); 
        Assert.That(result, Is.EqualTo(new List<string>(){"1: a", "2: b", "3: c"}));
    }
    
    [Test]
    public void LineNumbering_ArrayWithEmptyStrings_ReturnsArrayWithLineNumbers()
    {
        var input = new List<string> { "", "", "" }; 
        var result = LineNumbering.Number(input); 
        Assert.That(result, Is.EqualTo(new List<string>(){"1: ", "2: ", "3: "}));
    }
    
}