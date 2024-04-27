namespace LeetCode.Easy.Arrays;

public static class DecompressRunLenghtEncodedList
{
    public static IEnumerable<int> Run(int[] nums)
    {
        var arr = new List<int>();

        for (var i = 0; i <= nums.Length - 1; i += 2)
        {
            for (var j = 0; j < nums[i]; j++)
            {
                arr.Add(nums[i + 1]);
            }
        }

        return arr.ToArray();
    }
}