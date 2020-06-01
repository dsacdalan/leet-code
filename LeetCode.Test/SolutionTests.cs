using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;
using System.Collections.Generic;
using System;
using System.Linq;

namespace LeetCode.Test
{
    [TestClass]
    public class SolutionTests
    {
        private readonly Solution _service;

        public SolutionTests()
        {
            _service = new Solution();
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

                [TestMethod]
        public void SearchInsertPosition_1()
        {
            var nums = new int[] {1,3,5,6};
            var target = 5;

            var result = _service.SearchInsert(nums, target);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SearchInsertPosition_2()
        {
            var nums = new int[] {1,3,5,6};
            var target = 2;

            var result = _service.SearchInsert(nums, target);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void SearchInsertPosition_3()
        {
            var nums = new int[] {1,3,5,6};
            var target = 7;

            var result = _service.SearchInsert(nums, target);

            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void SearchInsertPosition_4()
        {
            var nums = new int[] {1,3,5,6};
            var target = 0;

            var result = _service.SearchInsert(nums, target);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SearchInsertPosition_5()
        {
            var nums = new int[] {1};
            var target = 2;

            var result = _service.SearchInsert(nums, target);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SearchInsertPosition_6()
        {
            var nums = new int[] {1,3};
            var target = 0;

            var result = _service.SearchInsert(nums, target);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SearchInsertPosition_()
        {
            var nums = new int[] {3,4,5,6,7,8};
            var target = 6;

            var result = _service.SearchInsert(nums, target);

            Assert.AreEqual(3, result);
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

        [TestMethod]
        public void MaxConsecutive1s_1()
        {
            var A = new int[] {1,1,1,0,0,0,1,1,1,1,0};
            var K = 2;

            var result = _service.LongestOnes(A, K);

            Assert.AreEqual(6, result);
        }

        // [TestMethod]
        // public void MaxConsecutive1s_2()
        // {
        //     var A = new int[] {0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1};
        //     var K = 3;

        //     var result = _max.LongestOnes(A, K);

        //     Assert.AreEqual(10, result);
        // }

        [TestMethod]
        public void Grumpy_1()
        {
            var customers = new int[] {1,0,1,2,1,1,7,5};
            var grumpy = new int[] {0,1,0,1,0,1,0,1};
            var X = 3;

            var result = _service.MaxSatisfied(customers, grumpy, X);

            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void Grumpy_2()
        {
            var customers = new int[] {9,10,4,5};
            var grumpy = new int[] {1,0,1,1};
            var X = 1;

            var result = _service.MaxSatisfied(customers, grumpy, X);

            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void Grumpy_3()
        {
            var customers = new int[] {3,8,8,7,1};
            var grumpy = new int[] {1,1,1,1,1};
            var X = 3;

            var result = _service.MaxSatisfied(customers, grumpy, X);

            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Grumpy_4()
        {
            var customers = new int[] {7,8,8,6};
            var grumpy = new int[] {0,1,0,1};
            var X = 3;

            var result = _service.MaxSatisfied(customers, grumpy, X);

            Assert.AreEqual(29, result);
        }

        [TestMethod]
        public void EmployeeImportance_1()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee
            {
                id = 1,
                importance = 5,
                subordinates = new List<int> {2}
            });
            employees.Add(new Employee
            {
                id = 2,
                importance = 1,
                subordinates = new List<int>()
            });

            var result = _service.GetImportance(employees, 1);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void RecentCounter_1()
        {
            var obj = new RecentCounter();
            Assert.AreEqual(1, obj.Ping(1));
            Assert.AreEqual(2, obj.Ping(100));
            Assert.AreEqual(3, obj.Ping(3001));
            Assert.AreEqual(3, obj.Ping(3002));
            Assert.AreEqual(1, obj.Ping(10000));
        }

        [TestMethod]
        public void LeafSimilar_1()
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };

            var result = _service.LeafSimilar(root, root);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FloodFill_1()
        {
            int[][] image = new int[3][];
            image[0] = new int[] {1,1,1};
            image[1] = new int[] {1,1,0};
            image[2] = new int[] {1,0,1};

            var sr = 1;
            var sc = 1;
            var newColor = 2;

            var result = _service.FloodFill(image, sr, sc, newColor);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FloodFill_2()
        {
            int[][] image = new int[2][];
            image[0] = new int[] {0,0,0};
            image[1] = new int[] {0,1,1};

            var sr = 1;
            var sc = 1;
            var newColor = 1;

            var result = _service.FloodFill(image, sr, sc, newColor);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void NumTeams_1()
        {
            var rating = new int[] {1,2,3,4,};

            var result = _service.NumTeams(rating);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void FindDuplicates_1()
        {
            var nums = new int [] {4,3,2,7,8,2,3,1};

            var result = _service.FindDuplicates(nums);
            
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Where(x => x == 2).Any());
            Assert.IsTrue(result.Where(x => x == 3).Any());
        }

        [TestMethod]
        public void FindDuplicates_2()
        {
            var nums = new int [] {10,2,5,10,9,1,1,4,3,7};

            var result = _service.FindDuplicates(nums);
            
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Where(x => x == 10).Any());
            Assert.IsTrue(result.Where(x => x == 1).Any());
        }
    }
}