using CSharpUnitTestKatas.DailyKatas.Numbers;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas.Numbers;

[TestFixture]
public class RomanConvertTests
{
    [Test]
    [TestCase(1000, "M")]
    [TestCase(900, "CM")]
    [TestCase(500, "D")]
    [TestCase(400, "CD")]
    [TestCase(100, "C")]
    [TestCase(90, "XC")]
    [TestCase(50, "L")]
    [TestCase(40, "XL")]
    [TestCase(10, "X")]
    [TestCase(9, "IX")]
    [TestCase(5, "V")]
    [TestCase(4, "IV")]
    [TestCase(1, "I")]
    [TestCase(1666, "MDCLXVI")]
    [TestCase(2025, "MMXXV")]
    [TestCase(3888, "MMMDCCCLXXXVIII")]
    public void RomanConver_ValidNumber_ReturnsRomanNumerals(int num, string romResult)
    {
        var result = RomanConvert.ToRoman(num);
        Assert.That(result, Is.EqualTo(romResult));
    }
    
}