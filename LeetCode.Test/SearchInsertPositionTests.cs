using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;

namespace LeetCode.Test
{
    [TestClass]
    public class SearchInsertPositionTests
    {
        private readonly SearchInsertPosition _service;

        public SearchInsertPositionTests()
        {
            _service = new SearchInsertPosition();
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
    }
}