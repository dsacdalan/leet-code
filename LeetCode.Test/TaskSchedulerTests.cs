using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;

namespace LeetCode.Test
{
    [TestClass]
    public class TaskSchedulerTests
    {
        private readonly TaskScheduler _taskScheduler;

        public TaskSchedulerTests()
        {
            _taskScheduler = new TaskScheduler();
        }

        [TestMethod]
        public void TaskScheduler_1() 
        {
            var tasks = new char[] {'A','A','A','B','B','B'};
            var n = 2;

            var result = _taskScheduler.LeastInterval(tasks, n);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TaskScheduler_2() 
        {
            var tasks = new char[] {'A','A','A','A','A','A','B','C','D','E','F','G'};
            var n = 2;

            var result = _taskScheduler.LeastInterval(tasks, n);

            Assert.AreEqual(16, result);
        }
    }
}