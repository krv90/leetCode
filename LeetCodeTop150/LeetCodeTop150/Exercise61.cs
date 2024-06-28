namespace LeetCodeTop150;

/// <summary>
/// 61. Rotate List
/// </summary>
/// <remarks>
/// Given the head of a linked list, rotate the list to the right by k places.
/// </remarks>
public class Exercise61
{
    public static ListNode RotateRight(ListNode head, int k)
    {
        if (k == 0 || head?.next == null)
        {
            return head;
        }
        
        var len = 0;
        var current = head;
        var reverseItems = new Stack<ListNode>();
        while (current != null)
        {
            reverseItems.Push(current);
            len++;
            
            current = current.next;
        }

        ListNode newHead = null;
        ListNode prevHead = head;
        var rotatesSteps = k % len;
        
        while (rotatesSteps > 0)
        {
            newHead = reverseItems.Pop();
            newHead.next = prevHead;
            prevHead = newHead;
            rotatesSteps--;
        }
        
        var tail = reverseItems.Pop();
        tail.next = null;

        return newHead ?? head;
    }

    public class ListNode {
         public int val;
             public ListNode next;
             public ListNode(int val=0, ListNode next=null) {
                 this.val = val;
                 this.next = next;
             }

             public static ListNode FromArray(params int[] arr)
             {
                 var head = new ListNode(arr[0]);

                 var current = head;
                 for (int i = 1; i < arr.Length; i++)
                 {
                     current.next = new ListNode(arr[i]);
                     current = current.next;
                 }

                 return head;
             }

             public List<int> ToList()
             {
                 var result = new List<int>();
                 
                 var current = this;
                 while (current != null)
                 {
                     result.Add(current.val);
                     current = current.next;
                 }

                 return result;
             }
     }
}


