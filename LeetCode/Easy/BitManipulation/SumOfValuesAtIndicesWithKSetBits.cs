namespace LeetCode.Easy.BitManipulation;

public static class SumOfValuesAtIndicesWithKSetBits
{
    public static int Run(IList<int> nums, int k)
    {
        var result = 0;
        
        for (var i = 0; i < nums.Count; i++)
        {
            if (CountSetBits((uint)i) == k)
                result += nums[i];
        }

        return result;
    }

    private static int CountSetBits(uint n)
    {
        var count = 0;
        
        while (n != 0)
        {
            count += (int)(n & 1);
            n >>= 1;
        }
        return count;
    }
}