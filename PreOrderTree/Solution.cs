using System;
using System.Collections.Generic;
using System.Text;

namespace PreOrderTree
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
        
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            if (root == null) return result;

            RecursivePreOrder(root, result);

            return result;
        }

        private void RecursivePreOrder(TreeNode node, List<int> result)
        {
            
            result.Add(node.val);

            if(node.left != null)
                RecursivePreOrder(node.left, result);

            if(node.right != null)
                RecursivePreOrder(node.right, result);
        }
    }
}
