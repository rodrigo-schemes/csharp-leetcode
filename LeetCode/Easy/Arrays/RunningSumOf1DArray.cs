namespace LeetCode.Easy.Arrays;

public static class RunningSumOf1DArray
{
    public static IEnumerable<int> Run(int[] nums)
    {
        for (var i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }
}