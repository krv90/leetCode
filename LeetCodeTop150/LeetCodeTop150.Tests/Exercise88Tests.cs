namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise88Tests
{
    [Test]
    public void Case1()
    {
        int[] nums1 = { 1,2,3,0,0,0 };
        const int m = 3;
        int[] nums2 = {2,5,6};
        const int n = 3;
        
        Exercise88.Merge(nums1, m, nums2, n);

        nums1.Should().BeEquivalentTo(new int[] { 1, 2, 2, 3, 5, 6 });
    }
    
    [Test]
    public void Case2()
    {
        int[] nums1 = { 1 };
        var m = 1;
        int[] nums2 = {};
        var n = 0;
        
        Exercise88.Merge(nums1, m, nums2, n);

        nums1.Should().BeEquivalentTo(new int[] { 1 });
    }
    
    [Test]
    public void Case3()
    {
        int[] nums1 = { 0 };
        var m = 0;
        int[] nums2 = { 1 };
        var n = 1;
        
        Exercise88.Merge(nums1, m, nums2, n);

        nums1.Should().BeEquivalentTo(new int[] { 1 });
    }
    
    [Test]
    public void Case4()
    {
        int[] nums1 = { 4,5,6,0,0,0 };
        var m = 3;
        int[] nums2 = {1, 2, 3};
        var n = 3;
        
        Exercise88.Merge(nums1, m, nums2, n);

        nums1.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 5, 6 });
    }
    
    [Test]
    public void Case5()
    {
        int[] nums1 = { 1,2,3,0,0,0 };
        var m = 3;
        int[] nums2 = {4, 5, 6};
        var n = 3;
        
        Exercise88.Merge(nums1, m, nums2, n);

        nums1.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 5, 6 });
    }
}