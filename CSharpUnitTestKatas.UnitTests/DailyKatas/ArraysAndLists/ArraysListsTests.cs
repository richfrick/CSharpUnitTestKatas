using CSharpUnitTestKatas.DailyKatas.ArraysAndLists;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas.ArraysAndLists;

[TestFixture]
public class ArraysListsTests
{
    [TestFixture]
    public class RemoveEveryOther()
    {
        [Test]
        public void RemoveEveryOther_WhenPassedStringArray_RemovesEverySecondElement()
        {
            var input = new[] { "keep", "remove", "keep", "remove" };
            var result = ArraysLists.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new []{"keep", "keep"}));
        }
        
        [Test]
        public void RemoveEveryOther_WhenPassedNestedArray_RemovesEverySecondElement()
        {
            var input = new object[] { new object[] { 1, 2 } };
            var result = ArraysLists.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new object[] { new object[] { 1, 2 } }));
        }
        
        [Test]
        public void RemoveEveryOther_WhenPassedIntArray_RemovesEverySecondElement()
        {
            var input = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = ArraysLists.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new object[]{ 1, 3, 5, 7, 9 }));
        }
        
        [Test]
        public void RemoveEveryOther_WhenPassedNestedObjects_RemovesEverySecondElement()
        {
            var input = new object[] { new object[] { "Goodbye" }, new Dictionary<string,string>(){{"Great", "Job"}}};
            var result = ArraysLists.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new object[] { new object[] { "Goodbye" } }));
        }
        
        [Test]
        public void RemoveEveryOther_WhenPassedEmptyArray_RemovesEverySecondElement()
        {
            var input = new object[] { };
            var result = ArraysLists.RemoveEveryOtherRefactor(input);
            Assert.That(result, Is.EqualTo(new object[] { }));
        }
    }
    
    [TestFixture]
    public class GetUnique
    {
        [Test]
        [TestCase(new [] { 1,2,2,2 }, 1)]
        [TestCase(new [] { -2,2,2,2 }, -2)]
        [TestCase(new [] { 11,11,14,11,11 }, 14)]
        public void GetUnique_WhenPassedList_ReturnsTheUniquesNumber(IEnumerable<int> ip, int res )
        {
            var result = ArraysLists.GetUniqueRefactor(ip);
            Assert.That(result, Is.EqualTo(res));    
        }
    }
    
    [TestFixture]
    public class Digitize
    {
        [Test]
        [TestCase(35231, new long[]{1,3,2,5,3})]
        [TestCase(0, new long[]{0})]
        public void Digitize_test(long input, long[] output)
        {
            var result = ArraysLists.Digitizer(input);
            Assert.That(result, Is.EqualTo(output));
        }
    }
    
    [TestFixture]
    public class Array
    {
        [Test]
        [TestCase("", null)]
        [TestCase("1", null)]
        [TestCase("1,2", null)]
        [TestCase("1, 3",null)]
        [TestCase("1,2,3", "2")]
        [TestCase("1,2,3, 4", "2 3")]
        public void Array_ArrayWithMoreThan2CommaSeparatedChars_ReturnsNewString(string input, string? output)
        {
            var result = ArraysLists.Array(input);
            Assert.That(result, Is.EqualTo(output));
        }
    }
}