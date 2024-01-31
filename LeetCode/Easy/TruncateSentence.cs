namespace LeetCode.Easy;

public static class TruncateSentence
{
    public static string Run(string s, int k)
    {
        var splited = s.Split(" ");
        var truncated = splited.Take(k).ToArray();

        return string.Join(" ", truncated);
    }
}