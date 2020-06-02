namespace LeetCode.Service
{
    public class IncreasingOrderTree
    {
        private TreeNode Helper(TreeNode root, TreeNode nextNode)
        {
            if (root == null) {
                return nextNode;
            }
            
            var tree = Helper(root.left, root);
            root.left = null;
            root.right = Helper(root.right, nextNode);
            
            return tree;
        }
        
        public TreeNode IncreasingBST(TreeNode root) {
            return Helper(root, null);
        }
    }
}