using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using InOrderTree;

namespace LeetcodeProblemsTests.Trees
{
   
    public class InOrderTreeTest
    {
        public static IEnumerable<object[]> Inputs =>
           new List<object[]>
           {
                new object[]
                {
                    new TreeNode(6){left = new TreeNode(2){left = new TreeNode(0), right = new TreeNode(4){left = new TreeNode(3), right = new TreeNode(5) } }, right = new TreeNode(8){left = new TreeNode(7), right = new TreeNode(9)} },
                    new List<int>() {0, 2, 3,4,5,6,7,8,9 }
                }
          };

        [Theory]
        [MemberData(nameof(Inputs))]
        public void TestSolution(TreeNode root, List<int> expected)
        {
            Solution solution = new Solution();
            IList<int> actual = solution.InorderTraversal(root);
            Assert.Equal(expected, actual);
        }
    }
}
