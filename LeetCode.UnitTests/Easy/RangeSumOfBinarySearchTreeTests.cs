using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class RangeSumOfBinarySearchTreeTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void RangeSumOfBinarySearchTree_UnitTest(TreeNode? treeNode, int low, int high, int expected)
    {
        var result = RangeSumOfBinarySearchTree.Run(treeNode, low, high);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return
        [
            new TreeNode(10, new TreeNode(5, new TreeNode(3), new TreeNode(7)),
                new TreeNode(15, null, new TreeNode(18))), 7, 15, 32
        ];

        yield return
        [
            new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(1)), new TreeNode(7, new TreeNode(6))),
                new TreeNode(15, new TreeNode(13), new TreeNode(18))), 6, 10, 23
        ];

    }
}

