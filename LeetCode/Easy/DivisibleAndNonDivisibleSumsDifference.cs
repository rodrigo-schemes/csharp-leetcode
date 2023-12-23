namespace LeetCode.Easy;

public static class DivisibleAndNonDivisibleSumsDifference
{
    public static int Run(int n, int m)
    {
        var num1 = 0;
        var num2 = 0;

        for (var i = 1; i <= n; i++)
        {
            if (i % m != 0)
            {
                num1 += i;
                continue;
            }
            
            num2 += i;
        }

        return num1 - num2;
    }
}