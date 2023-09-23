namespace LeetCode.Easy;

public static class RansomNote
{
    public static bool Run(string ransomNote, string magazine)
    {
        if (magazine.Length < ransomNote.Length) return false;
        var lettersHash = new Dictionary<char, int>();

        foreach (var letter in magazine)
        {
            if (lettersHash.TryGetValue(letter, out _))
            {
                lettersHash[letter] ++;
            }
            else
            {
                lettersHash.Add(letter, 1);
            }
        }

        foreach (var t in ransomNote)
        {
            if (!lettersHash.TryGetValue(t, out var count) || count == 0)
            {
                return false;
            }

            lettersHash[t]--;
        }
        
        return true;
    }
}