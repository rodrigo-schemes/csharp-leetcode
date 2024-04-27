namespace LeetCode.Easy.Arrays;

public static class MaximumNumberOfWordsFoundInSentences
{
    public static int Run(string[] sentences)
    {
        var biggest = 0;
        
        foreach (var t in sentences)
        {
            var count = 1 + t.Count(letter => letter.Equals(' '));
            if (count > biggest) biggest = count;
        }

        return biggest;
    }
}