namespace LeetCode.Easy.Strings;

public static class SplitAStringInBalancedStrings
{
    public static int Run(string s)
    {
        int result = 0;
        int balance = 0;

        foreach (char letter in s)
        {
            balance = letter == 'R' ? 
                balance + 1 : 
                balance - 1;

            if (balance == 0) result++;
        }

        return result;
    }
}