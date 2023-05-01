using System;
using System.Collections.Generic;
using System.Text;

namespace LowestCommonAnsestorOfBinarySearchTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    { 

        //54min
        //If both values are by the same side continue looking
        //if both values are in different side this node is the parent
        //if you find the value, does not matter the remaining, this is the parent

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
           

            while(true)
            {
                if (p.val > root.val && q.val < root.val)
                {
                    return root;
                }

                if (q.val > root.val && p.val < root.val)
                {
                    return root;
                }

                if (p.val == root.val || q.val == root.val)
                {
                    return root;
                }

                else if(p.val > root.val)
                {
                    root = root.right;
                }
                else
                {
                    root = root.left;
                }
            }





        }

 

    }
}
