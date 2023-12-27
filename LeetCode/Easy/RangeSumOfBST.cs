﻿namespace LeetCode.Easy;

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

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public readonly int Val = val;
    public readonly TreeNode? Left = left;
    public readonly TreeNode? Right = right;
}