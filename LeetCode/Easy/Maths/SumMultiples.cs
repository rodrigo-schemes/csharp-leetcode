namespace LeetCode.Easy.Maths;

public static class SumMultiples
{
    public static int Run(int n)
    {
        var result = 0;
        
        for (var x = 1; x <= n; x++)
        {
            if (x % 3 == 0 || x % 5 == 0 || x % 7 == 0) result += x;
        }

        return result;
    }
}