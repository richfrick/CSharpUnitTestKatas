using CSharpUnitTestKatas.DailyKatas;

namespace CSharpUnitTestKatas.UnitTests.DailyKatas;

[TestFixture]
public class MoveZerosTests
{
    [Test]
    public void MoveZerosSolution_ArrayWithZeros_ReturnsArrayWithZerosAtEnd()
    {
        var result = MoveZeros.MoveZerosSolutionRefactor(new[] {1,2,3,0,4,0,5,0});

        Assert.That(result, Is.EqualTo(new[]{1,2,3,4,5,0,0,0}));
    }
    
    [Test]
    public void MoveZerosSolution_ArrayWithNoZeros_ReturnsSameArray()
    {
        var result = MoveZeros.MoveZerosSolution(new[] {1,2,3,4,5});

        Assert.That(result, Is.EqualTo(new[]{1,2,3,4,5}));
    }
    
    [Test]
    public void MoveZerosSolution_EmptyArray_ReturnsEmptyArray()
    {
        var result = MoveZeros.MoveZerosSolution(new int[] {});

        Assert.That(result, Is.EqualTo(new int[]{}));
    }
}