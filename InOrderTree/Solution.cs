using System;
using System.Collections.Generic;
using System.Text;

namespace InOrderTree
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

        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
                return result;

            return RecursiveInorder(root, result);
 
        }
        
        private List<int> RecursiveInorder(TreeNode node, List<int> result)
        {
            if(node.left != null)
            {
                RecursiveInorder(node.left, result);
            }

            result.Add(node.val);

            if(node.right != null)
            {
                RecursiveInorder(node.right, result);
            }

            return result;
        }
    }
}
