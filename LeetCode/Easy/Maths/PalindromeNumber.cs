namespace LeetCode.Easy.Maths;

public static class PalindromeNumber
{
    public static bool Run(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        var reversedNumber = 0;
        var originalNumber = x;

        while (x > 0)
        {
            var digit = x % 10;
            reversedNumber = reversedNumber * 10 + digit;
            x /= 10;
        }

        return originalNumber == reversedNumber;
    }
}