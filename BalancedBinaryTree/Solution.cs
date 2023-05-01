using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedBinaryTree
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
        bool isBalanced = true;
        public bool IsBalanced(TreeNode root)
        {
            IsBalancedRecursive(root);
            return isBalanced;
        }

        private int IsBalancedRecursive(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = IsBalancedRecursive(root.left);
            int right = IsBalancedRecursive(root.right);

            if (Math.Abs(left - right) > 1)
                isBalanced = false;

            return Math.Max(left,right) + 1;
        }


        
    }
}
