namespace LeetCodeTop150;

/// <summary>
/// 141. Linked List Cycle
/// </summary>
public static class Exercise141
{
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; next = null; }
  }
 
    public static bool HasCycle(ListNode head)
    {
        var current = head;
        var i = 0;
        
        while (current != null && i <= 10_000) // тупо, но это самый простой вариант из условий задачи 
        {
            current = current.next;
            if (current == null)
            {
                return false;
            }

            i++;
        }
        
        return current != null;
    }
    
    public static bool HasCycle2(ListNode head)
    {
        if (head == null) return false;
        
        var slow = head;
        var fast = head;
        var i = 1;
        const int max = 10_000;

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if(slow == fast || i > max)  return true;

            i++;
        }

        return false;
    }
}