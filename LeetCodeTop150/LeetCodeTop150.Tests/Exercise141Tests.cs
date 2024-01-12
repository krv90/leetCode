using FluentAssertions.Equivalency;
using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise141Tests
{
    [Test]
    public void Case1()
    {
        var head = GetHead(new[] { 3, 2, 0, -4 }, pos: 1);
        Exercise141.HasCycle(head).Should().Be(true);
    }
    
    [Test]
    public void Case2()
    {
        var head = GetHead(new[] { 1, 2 }, pos: 0);

        Exercise141.HasCycle(head).Should().Be(true);
    }
    
    [Test]
    public void Case3()
    {
        var head = GetHead(new[] { 1 }, pos: -1);

        Exercise141.HasCycle(head).Should().Be(false);
    }
    
    [Test]
    public void Case4()
    {
        var head = GetHead(new[] { -21,10,17,8,4,26,5,35,33,-7,-16,27,-12,6,29,-12,5,9,20,14,14,2,13,-24,21,23,-21,5 }, pos: -1);

        Exercise141.HasCycle(head).Should().Be(false);
    }
    
    [Test]
    public void Case5()
    {
        var head = GetHead(Array.Empty<int>(), pos: -1);

        Exercise141.HasCycle(head).Should().Be(false);
    }
    
    [Test]
    public void Solution2Case1()
    {
        var head = GetHead(new[] { 3, 2, 0, -4 }, pos: 1);
        Exercise141.HasCycle2(head).Should().Be(true);
    }
    
    [Test]
    public void Solution2Case2()
    {
        var head = GetHead(new[] { 1, 2 }, pos: 0);

        Exercise141.HasCycle2(head).Should().Be(true);
    }
    
    [Test]
    public void Solution2Case3()
    {
        var head = GetHead(new[] { 1 }, pos: -1);

        Exercise141.HasCycle2(head).Should().Be(false);
    }
    
    [Test]
    public void Solution2Case4()
    {
        var head = GetHead(new[] { -21,10,17,8,4,26,5,35,33,-7,-16,27,-12,6,29,-12,5,9,20,14,14,2,13,-24,21,23,-21,5 }, pos: -1);

        Exercise141.HasCycle2(head).Should().Be(false);
    }
    
    [Test]
    public void Solution2Case5()
    {
        var head = GetHead(Array.Empty<int>(), pos: -1);

        Exercise141.HasCycle2(head).Should().Be(false);
    }

    private static Exercise141.ListNode GetHead(int[] arr, int pos)
    {
        Exercise141.ListNode headNode = null;
        Exercise141.ListNode prevNode = null;
        Exercise141.ListNode posNode = null;
        
        for (int i = 0; i < arr.Length; i++)
        {
            var currNode = new Exercise141.ListNode(arr[i]);
            if (prevNode != null)
            {
                prevNode.next = currNode;
            }
            
            if (i == 0)
            {
                headNode = currNode;
            }

            if (i == pos)
            {
                posNode = currNode;
            }

            prevNode = currNode;
        }

        if (posNode != null && prevNode != null)
        {
            prevNode.next = posNode;
        }

        return headNode;
    }
}