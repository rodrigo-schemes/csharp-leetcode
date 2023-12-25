namespace LeetCode.Easy;

public static class HowManyNumbersAreSmallerThanTheCurrentNumber
{
    public static IEnumerable<int> Run(int[] nums)
    {
        var result = new int[nums.Length];
        
        for (var i = 0; i < nums.Length; i++)
        {
            var smaller = nums.Count(t => t < nums[i]);
            result[i] = smaller;
        }

        return result;
    }
}