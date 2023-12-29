using LeetCode.Shared;

namespace LeetCode.Easy;

public static class FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
{
    public static TreeNode? Run(TreeNode? original, TreeNode? cloned, TreeNode? target) {
        if (original is null || cloned is null || target is null)
        {
            return null;
        }        

        if (original.Val == target.Val)
        {
            return cloned;
        }

        var left = Run(original.Left, cloned.Left, target);
        var right = Run(original.Right, cloned.Right, target);

        if (left is not null)
        {
            return left;
        }
        if (right is not null)
        {
            return right;
        }

        if (cloned.Left is null && cloned.Right is null)
        {
            return null;
        }
        return null;
    }
}