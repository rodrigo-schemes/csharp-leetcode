namespace LeetCode.Shared;

public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public readonly int Val = val;
    public readonly TreeNode? Left = left;
    public readonly TreeNode? Right = right;
}