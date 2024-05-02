using System.Text;

namespace LeetCode.Easy.Pointers;

public static class ReversePrefixOfWord
{
    public static string Run(string word, char ch)
    {
        var position = word.IndexOf(ch);
        if (position == -1)
        {
            return word;
        }

        var result = new StringBuilder(word);
        
        var left = 0;
        var right = position;
        while (left < right)
        {
            char temp = result[left];
            result[left] = result[right];
            result[right] = temp;
            left++;
            right--;
        }

        return result.ToString();
    }
}