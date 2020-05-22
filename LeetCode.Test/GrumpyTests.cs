using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;

namespace LeetCode.Test
{
    [TestClass]
    public class GrumpyTests
    {
        private readonly GrumpyOwner _grumpy;

        public GrumpyTests()
        {
            _grumpy = new GrumpyOwner();
        }

        [TestMethod]
        public void Grumpy_1()
        {
            var customers = new int[] {1,0,1,2,1,1,7,5};
            var grumpy = new int[] {0,1,0,1,0,1,0,1};
            var X = 3;

            var result = _grumpy.MaxSatisfied(customers, grumpy, X);

            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void Grumpy_2()
        {
            var customers = new int[] {9,10,4,5};
            var grumpy = new int[] {1,0,1,1};
            var X = 1;

            var result = _grumpy.MaxSatisfied(customers, grumpy, X);

            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void Grumpy_3()
        {
            var customers = new int[] {3,8,8,7,1};
            var grumpy = new int[] {1,1,1,1,1};
            var X = 3;

            var result = _grumpy.MaxSatisfied(customers, grumpy, X);

            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Grumpy_4()
        {
            var customers = new int[] {7,8,8,6};
            var grumpy = new int[] {0,1,0,1};
            var X = 3;

            var result = _grumpy.MaxSatisfied(customers, grumpy, X);

            Assert.AreEqual(29, result);
        }
    }
}
