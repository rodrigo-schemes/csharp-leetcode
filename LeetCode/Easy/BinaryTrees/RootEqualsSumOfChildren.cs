using LeetCode.Shared;

namespace LeetCode.Easy.BinaryTrees;

public static class RootEqualsSumOfChildren
{
    public static bool Run(TreeNode root)
    {
        return root.Val == root.Left!.Val + root.Right!.Val;
    }
}