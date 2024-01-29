namespace LeetCode.Easy;

public static class CheckIfTwoStringArraysAreEquivalent
{
    public static bool Run(IEnumerable<string> word1, IEnumerable<string> word2)
    {
        var result1 = string.Empty;
        var result2 = string.Empty;

        result1 = word1.Aggregate(result1, (current, letter) => current + letter);
        result2 = word2.Aggregate(result2, (current, letter) => current + letter);

        return result1 == result2;
    }
}