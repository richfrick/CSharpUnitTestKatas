namespace CSharpUnitTestKatas.UnitTests.Fundamentals;

using CSharpUnitTestKatas.Fundamentals;

[TestFixture]
public class StackTests
{
    [Test]
    public void Count_EmptyStack_ReturnZero()
    {
        var stack = new Stack<string>();
        Assert.That(stack.Count, Is.EqualTo(0));
    }

    [Test]
    public void Push_PassNull_ThrowsError()
    {
        var stack = new Stack<string>();
        Assert.That(() => stack.Push(null),Throws.ArgumentNullException);
    }

    [Test]
    public void Push_ValidArg_AddsToList()
    {
        var strList = new System.Collections.Generic.Stack<string>();
        strList.Push("foo");
        Assert.That(strList.Count, Is.EqualTo(1));
    }

    [Test]
    public void Pop_EmptyStack_ThrowsException()
    {
        var stack = new Stack<string>();
        Assert.That(() => stack.Pop(),Throws.InvalidOperationException);
    }
    
    [Test]
    public void Pop_StackWithObjects_ReturnsFirstObjectInStack()
    {
        var stack = new Stack<string>();
        stack.Push("foo");
        stack.Push("bar");
        var result = stack.Pop();
        Assert.That(result, Is.EqualTo("bar"));
    }
    
    [Test]
    public void Pop_StackWithObjects_RemovesFirstObjectInStack()
    {
        var stack = new Stack<string>();
        stack.Push("foo");
        stack.Push("bar");
        stack.Pop();
        Assert.That(stack.Count, Is.EqualTo(1));
    }

    [Test]
    public void Peek_StackWithNoObjects_ThrowsException()
    {
        var stack = new Stack<string>();
        Assert.That(() => stack.Peek(), Throws.Exception.TypeOf<InvalidOperationException>());
    }

    [Test]
    public void Peek_StackWithSome_ReturnsFirstObjectInStack()
    {
        var stack = new Stack<string>();
        stack.Push("foo");
        stack.Push("bar");
        var result = stack.Peek();
        Assert.That(result, Is.EqualTo("bar"));
    }
    
    [Test]
    public void Peek_StackWithSome_DoesNotRemoveObjectFromStack()
    {
        var stack = new Stack<string>();
        stack.Push("foo");
        stack.Push("bar");
        stack.Peek();
        Assert.That(stack.Count, Is.EqualTo(2));
    }
}