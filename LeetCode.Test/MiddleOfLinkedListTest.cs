using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;

namespace LeetCode.Test
{
    [TestClass]
    public class MiddleOfLinkedListTest
    {
        private readonly MiddleOfLinkedList _service;

        public MiddleOfLinkedListTest()
        {
            _service = new MiddleOfLinkedList();
        }

        [TestMethod]
        public void MiddleOfLinkedList_1()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            var result = _service.MiddleNode(head);

            Assert.AreEqual(3, result.val);
        }

        [TestMethod]
        public void MiddleOfLinkedList_2()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);


            var result = _service.MiddleNode(head);

            Assert.AreEqual(4, result.val);
        }
    }
}