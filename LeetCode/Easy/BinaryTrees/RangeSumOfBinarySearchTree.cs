using LeetCode.Shared;

namespace LeetCode.Easy.BinaryTrees;

public static class RangeSumOfBinarySearchTree
{
    public static int Run(TreeNode? root, int low, int high)
    {
        if (root == null) return 0;

        var result = 0;

        if (root.Val > low)
            result += Run(root.Left, low, high);

        if (root.Val >= low && root.Val <= high)
            result += root.Val;

        if (root.Val < high)
            result += Run(root.Right, low, high);

        return result;
    }
}