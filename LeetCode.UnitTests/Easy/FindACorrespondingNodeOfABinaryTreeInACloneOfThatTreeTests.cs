using FluentAssertions;
using LeetCode.Easy;
using LeetCode.Shared;

namespace LeetCode.UnitTests.Easy;

public class FindACorrespondingNodeOfABinaryTreeInACloneOfThatTreeTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree_UnitTest(TreeNode original, TreeNode cloned, TreeNode target, TreeNode expected)
    {
        var result = FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree.Run(original, cloned, target);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return
        [
            new TreeNode(7, new TreeNode(4), new TreeNode(3, new TreeNode(6), new TreeNode(19))),
            new TreeNode(7, new TreeNode(4), new TreeNode(3, new TreeNode(6), new TreeNode(19))),
            new TreeNode(3, new TreeNode(6), new TreeNode(19)),
            new TreeNode(3, new TreeNode(6), new TreeNode(19))
        ];
        
        yield return
        [
            new TreeNode(7),
            new TreeNode(7),
            new TreeNode(7),
            new TreeNode(7)
        ];

        yield return
        [
            new TreeNode(8, null,
                new TreeNode(7, null,
                    new TreeNode(6, null,
                        new TreeNode(5, null,
                            new TreeNode(4, null, new TreeNode(3, null, new TreeNode(2, null, new TreeNode(1)))))))),
            new TreeNode(8, null,
                new TreeNode(7, null,
                    new TreeNode(6, null,
                        new TreeNode(5, null,
                            new TreeNode(4, null, new TreeNode(3, null, new TreeNode(2, null, new TreeNode(1)))))))),
            new TreeNode(4, null, new TreeNode(3, null, new TreeNode(2, null, new TreeNode(1)))),
            new TreeNode(4, null, new TreeNode(3, null, new TreeNode(2, null, new TreeNode(1))))
        ];
    }
}