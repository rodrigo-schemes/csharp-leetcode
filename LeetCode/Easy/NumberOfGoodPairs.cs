namespace LeetCode.Easy;

public static class NumberOfGoodPairs
{
    public static int Run(int[] nums)
    {
        var numsHash = new Dictionary<int, int>();
        var goodPairs = 0;

        foreach (var t in nums)
        {
            numsHash.TryAdd(t, 0);
            numsHash[t] += 1;
        }

        foreach (var (_, value) in numsHash) {
            goodPairs += value*(value - 1) / 2;
        }

        return goodPairs;
    }
}