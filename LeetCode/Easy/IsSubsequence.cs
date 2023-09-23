namespace LeetCode.Easy;

public static class IsSubsequence
{
    public static bool Run(string s, string t)
    {
        var sIndex = 0;
        
        foreach (var tChar in t)
        {
            if (sIndex < s.Length && tChar == s[sIndex])
            {
                sIndex++;
            }
        }

        return sIndex == s.Length;
    }
}