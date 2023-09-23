namespace LeetCode.Easy;

public static class TwoSum
{
    public static IEnumerable<int> Run(int[] nums, int target)
    {
        var indexes = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (indexes.TryGetValue(complement, out var complementIndex))
            {
                return new[] { complementIndex, i };
            }

            indexes[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}