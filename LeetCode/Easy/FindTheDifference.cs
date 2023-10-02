namespace LeetCode.Easy;

public static class FindTheDifference
{
    public static char Run(string s, string t)
    {
        var hash = new Dictionary<char, int>();
        
        foreach (var letter in s)
        {
            if (hash.TryGetValue(letter, out _))
            {
                hash[letter] ++;
            }
            else
            {
                hash.Add(letter, 1);
            }
        }

        foreach (var letterToFind in t)
        {
            if (!hash.TryGetValue(letterToFind, out var count) || count == 0)
            {
                return letterToFind;
            }

            hash[letterToFind]--;
        }

        return char.MinValue;
    }
}