using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;

namespace LeetCode.Test
{
    [TestClass]
    public class ReversedLinkedListTest
    {
        private readonly ReversedLinkedList _service;

        public ReversedLinkedListTest()
        {
            _service = new ReversedLinkedList();
        }

        [TestMethod]
        public void ReverseList()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            var result = _service.ReverseList(head);

            Assert.AreEqual(5, result.val);
        }
    }
}