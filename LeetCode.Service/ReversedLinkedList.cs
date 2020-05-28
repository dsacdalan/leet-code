using System.Collections.Generic;

namespace LeetCode.Service
{
    public partial class Solution
    {
        private ListNode Helper(ListNode head, ListNode reverse)
        {
            if (head == null)
                return reverse;

            var next = head.next;
            head.next = reverse;
            return Helper(next, head);
        }

        public ListNode ReverseList(ListNode head)
        {
            return Helper(head, null);
        }

        public ListNode ReverseList_Iterative(ListNode head)
        {
            ListNode reverse = null;

            while(head != null)
            {
                var next = head.next;
                head.next = reverse;
                reverse = head;
                head = next;
            }

            return reverse;
        }
    }
}