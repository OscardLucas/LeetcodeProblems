using System;
using System.Collections.Generic;
using System.Text;
using LowestCommonAnsestorOfBinarySearchTree;
using Xunit;
namespace LeetcodeProblemsTests.Trees
{
    public class LowestCommonAnsestorOfBinarySearchTreeTest
    {

        public static IEnumerable<object[]> inputs =>
            new List<object[]>
            {
                new object[]
                {
                    new TreeNode(6){left = new TreeNode(2){left = new TreeNode(0), right = new TreeNode(4){left = new TreeNode(3), right = new TreeNode(5) } }, right = new TreeNode(8){left = new TreeNode(7), right = new TreeNode(9)} },
                    new TreeNode(2), new TreeNode(8), 6
                }
           };
        
       [Theory]
       [MemberData(nameof(inputs))]
       public void TestSolution(TreeNode root, TreeNode p, TreeNode q, int expected)
        {
            Solution solution = new Solution();
            TreeNode actual = solution.LowestCommonAncestor(root, p, q);
            Assert.Equal(expected, actual.val);
        }

    }
}
