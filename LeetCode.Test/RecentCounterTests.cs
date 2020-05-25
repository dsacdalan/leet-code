using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;

namespace LeetCode.Test
{
    [TestClass]
    public class RecentCounterTests
    {
        private readonly RecentCounter _counter;

        public RecentCounterTests()
        {
            _counter = new RecentCounter();
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
    }
}
