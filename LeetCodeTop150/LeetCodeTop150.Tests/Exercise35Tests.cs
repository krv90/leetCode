namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise35Tests
{
    [Test]
    public void Case1()
    {
        int[] nums = [1,3,5,6];
        var target = 5;

        Exercise35.SearchInsert(nums, target).Should().Be(2);
    }

    [Test]
    public void Case2()
    {
        int[] nums = [1,3,5,6];
        var target = 2;

        Exercise35.SearchInsert(nums, target).Should().Be(1);
    }

    [Test]
    public void Case3()
    {
        int[] nums = [1,3,5,6];
        var target = 7;

        Exercise35.SearchInsert(nums, target).Should().Be(4);
    }

    [Test]
    public void Case4()
    {
        int[] nums = [5];
        var target = 7;

        Exercise35.SearchInsert(nums, target).Should().Be(1);
    }

    [Test]
    public void Case5()
    {
        int[] nums = [5];
        var target = 3;

        Exercise35.SearchInsert(nums, target).Should().Be(0);
    }
}