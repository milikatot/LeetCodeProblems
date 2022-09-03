
namespace LeetCodeProblems.Problems
{
    internal class Solution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new();
            ListNode l3 = head;
            int currValue = 0;
            int next = 0;

            while (l1 is not null || l2 is not null)
            {
                var l1Value = (l1?.val ?? 0);
                var l2Value = (l2?.val ?? 0);

                int currentSum = l1Value + l2Value + currValue;
                currValue = currentSum / 10;
                int lastDigit = currentSum % 10;
                
                l3.next = new(lastDigit);
               
                l1 = l1?.next;
                l2 = l2?.next;
                l3 = l3.next;
            }

            if (currValue > 0)
            {
                l3.next = new(currValue);
                l3 = l3.next;
            }
                

            return head.next;
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
