namespace LeetCode.Easy;

public static class ShuffleString
{
    public static string Run(string s, int[] indices)
    {
        var result = new char[indices.Length];

        for (var x = 0; x < indices.Length; x++)
        {
            result[indices[x]] = s[x];
        }

        return new string(result);
    }
}