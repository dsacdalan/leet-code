using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;

namespace LeetCode.Test
{
    [TestClass]
    public class IncreasingOrderTreeTests
    {
        private readonly IncreasingOrderTree _service;

        public IncreasingOrderTreeTests()
        {
            _service = new IncreasingOrderTree();
        }

        [TestMethod]
        public void IncreasingOrderTree_1()
        {
            var node = new TreeNode(2);
            node.left = new TreeNode(1);
            node.right = new TreeNode(3);

            var result = _service.IncreasingBST(node);
            
            Assert.AreEqual(1, result.val);
            Assert.IsNull(result.left);
            Assert.AreEqual(2, result.right);
            Assert.IsNull(result.right.left);
            Assert.AreEqual(3, result.right.right);
        }
    }
}