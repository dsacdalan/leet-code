using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;

namespace LeetCode.Test
{
    [TestClass]
    public class MaxConsecutive1sTests
    {
        private readonly MaxConsecutive1s _max;

        public MaxConsecutive1sTests()
        {
            _max = new MaxConsecutive1s();
        }

        [TestMethod]
        public void MaxConsecutive1s_1()
        {
            var A = new int[] {1,1,1,0,0,0,1,1,1,1,0};
            var K = 2;

            var result = _max.LongestOnes(A, K);

            Assert.AreEqual(6, result);
        }

                [TestMethod]
        public void MaxConsecutive1s_2()
        {
            var A = new int[] {0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1};
            var K = 3;

            var result = _max.LongestOnes(A, K);

            Assert.AreEqual(10, result);
        }
    }
}