namespace LeetCode.Easy.Arrays;

public static class CountPairsWhoseSumIsLessThanTarget
{
    public static int Run(IList<int> nums, int target)
    {
        var result = 0;
        
        for (var i = 0; i < nums.Count; i++)
        {
            for (var j = 0; j < nums.Count; j++)
            {
                var condition1 = i >= 0 && i < j;
                var condition2 = nums[i] + nums[j] < target;

                if (condition1 && condition2) result++;
            }
        }

        return result;
    }
}