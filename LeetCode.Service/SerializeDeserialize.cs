using System;
using System.Collections.Generic;

namespace LeetCode.Service
{
    public partial class Solution
    {
        private string _comma = ",";
        private string _null = "n";
        
        // Encodes a tree to a single string.
        public string serialize(TreeNode root) {
            var encoded = "";
            Flatten(root, ref encoded);
            return encoded;
        }

        private void Flatten(TreeNode root, ref string encoded) {
            if (root == null) {
                encoded = encoded + _null + _comma;
            }
            else {
                encoded = encoded + root.val.ToString() + _comma;
                Flatten(root.left, ref encoded);
                Flatten(root.right, ref encoded);
            }
        }
        
        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data) {
            string[] split = data.Split(',');
            var queue = new Queue<string>(split);
            return ProcessQueue(queue);
        }
        
        public TreeNode ProcessQueue(Queue<string> queue) {
            string current = queue.Dequeue();
            if (current == _null) return null;
            
            var root = new TreeNode(Int32.Parse(current));
            root.left = ProcessQueue(queue);
            root.right = ProcessQueue(queue);
            
            return root;
        } 
    }
}