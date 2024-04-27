namespace LeetCode.Easy.Arrays;

public static class FindWordsContainingCharacter
{
    public static IEnumerable<int> Run(string[] words, char x)
    {
        var result = new List<int>();

        for (var t = 0; t < words.Length; t ++)
        {
            foreach (var character in words[t])
            {
                if (character != x) continue;
                
                result.Add(t);
                break;
            }
        }
        
        return result;
    }
}