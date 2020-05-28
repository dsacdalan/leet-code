using System;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }

        public ListNode MiddleNode_2_Loops(ListNode head) {
            if (head.next == null)
                return head;
            
            var counter = 0;
            var answer = head;

            // Traverse the list to ge the length
            while(answer.next != null) {
                counter++;
                answer = answer.next;
            }

            // Find middle 
            var middle = counter / 2;
            if (counter % 2 != 0)
                middle++;

            counter = 0;
            answer = head;

            while (counter != middle){
                counter++;
                answer = answer.next;
            }
            
            return answer;
        }
    }
}