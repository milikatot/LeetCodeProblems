
namespace LeetCodeProblems.Problems
{
    internal class Solution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new();
            int currValue = 0;

            while (l1 != null || l2 != null)
            {
                var l1Value = (l1?.val ?? 0);
                var l2Value = (l2?.val ?? 0);

                currValue = l1Value + l2Value;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return head;
        }        
    }




    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
            this.val = val;
            this.next = next;
      }
    }
}
