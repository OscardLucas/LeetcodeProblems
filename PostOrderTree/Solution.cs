using System;
using System.Collections.Generic;
using System.Text;

namespace PostOrderTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            PostOrderRecursive(root, result);
            return result;
        }

        private void PostOrderRecursive(TreeNode node, List<int> result)
        {
            if (node == null)
                return;

            if (node.left != null)
                PostOrderRecursive(node.left, result);

            if (node.right != null)
                PostOrderRecursive(node.right, result);

            result.Add(node.val);
        }
    }
}
