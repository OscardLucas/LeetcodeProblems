using System;
using System.Collections.Generic;
using System.Text;

namespace InvertBinaryTree
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

    // 7min
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;

            TreeNode inverted = new TreeNode(root.val);
            inverted.left = InvertTree(root.right);
            inverted.right = InvertTree(root.left);

            return inverted;

        }

    }
}
