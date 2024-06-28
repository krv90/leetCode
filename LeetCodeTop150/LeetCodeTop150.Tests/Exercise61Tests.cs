namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise61Tests
{
    [Test]
    public void Case1()
    {
        Exercise61
            .RotateRight(Exercise61.ListNode.FromArray(1, 2, 3, 4, 5), 2)
            .ToList()
            .Should()
            .BeEquivalentTo(new[] { 4, 5, 1, 2, 3 }, opt => opt.WithStrictOrdering());
    }
    
    [Test]
    public void Case2()
    {
        Exercise61
            .RotateRight(Exercise61.ListNode.FromArray(0, 1, 2), 4)
            .ToList()
            .Should()
            .BeEquivalentTo(new[] { 2, 0, 1 }, opt => opt.WithStrictOrdering());
    }
    
    [Test]
    public void Case3()
    {
        Exercise61
            .RotateRight(Exercise61.ListNode.FromArray(1, 2), 0)
            .ToList()
            .Should()
            .BeEquivalentTo(new[] { 1, 2 }, opt => opt.WithStrictOrdering());
    }
    
    [Test]
    public void Case4()
    {
        Exercise61
            .RotateRight(Exercise61.ListNode.FromArray(1, 2), 2)
            .ToList()
            .Should()
            .BeEquivalentTo(new[] { 1, 2 }, opt => opt.WithStrictOrdering());
    }
}