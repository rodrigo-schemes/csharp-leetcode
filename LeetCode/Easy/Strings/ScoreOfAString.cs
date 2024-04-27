namespace LeetCode.Easy.Strings;

public static class ScoreOfAString
{
    public static int Run(string s)
    {
        var result = 0;
        
        for (var i = 0; i < s.Length - 1; i++)
        {
            result += Math.Abs(s[i] - s[i + 1]);
        }

        return result;
    }
}