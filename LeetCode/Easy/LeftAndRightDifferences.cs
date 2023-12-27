namespace LeetCode.Easy;

public static class LeftAndRightDifferences
{
    public static IEnumerable<int> Run(int[] nums)
    {
        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var leftSum = 0;
            var rightSum = 0;
            
            for (var left = i; left >= 0; left--)
            {
                leftSum += nums[left];
            }

            for (var right = i; right < nums.Length; right++)
            {
                rightSum += nums[right];
            }

            result[i] = Math.Abs(leftSum - rightSum);
        }
        
        return result;
    }
}