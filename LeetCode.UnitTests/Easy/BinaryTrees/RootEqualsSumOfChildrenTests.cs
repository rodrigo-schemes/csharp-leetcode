using FluentAssertions;
using LeetCode.Easy.BinaryTrees;
using LeetCode.Shared;

namespace LeetCode.UnitTests.Easy.BinaryTrees;

public class RootEqualsSumOfChildrenTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void RootEqualsSumOfChildren_UnitTest(TreeNode root, bool expected)
    {
        var result = RootEqualsSumOfChildren.Run(root);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new TreeNode(10, new TreeNode(4), new TreeNode(6)), true];
        yield return [new TreeNode(5, new TreeNode(3), new TreeNode(1)), false];
    }
}

