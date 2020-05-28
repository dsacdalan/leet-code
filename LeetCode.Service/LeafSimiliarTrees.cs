using System.Collections.Generic;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2) {
            var root1Leaves = Helper(root1);
            var root2Leaves = Helper(root2);
            return Compare(root1Leaves, root2Leaves);
        }
        
        private bool Compare(List<int> root1, List<int> root2)
        {
            if (root1.Count != root2.Count) return false;

            for(int i = 0; i < root1.Count; i++)
                if (root1[i] != root2[i]) return false;

            return true;
        }

        private List<int> Helper(TreeNode root)
        {
            var list = new List<int>();
            
            if (root == null) return list;

            list.AddRange(Helper(root.left));
            if (root.left == null && root.right == null)
                list.Add(root.val);
            list.AddRange(Helper(root.right));

            return list;
        }
    }
}