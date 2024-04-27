namespace LeetCode.Easy.Arrays;

public static class BuildArrayFromPermutation
{
    public static IEnumerable<int> Run(int[] nums)
    {
        var ans = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[nums[i]];
        }

        return ans;
    }
}