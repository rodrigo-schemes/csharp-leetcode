namespace LeetCode.Easy.HashTables;

public static class JewelsAndStones
{
    public static int Run(string jewels, string stones)
    {
        var hash = jewels.ToDictionary(t => t, t => 1);
        return stones.Sum(t => hash.GetValueOrDefault(t));
    }
}