namespace LeetCode.Easy;

public static class SmallestEvenMultiple
{
    public static int Run(int n)
    {
        if (n % 2 == 0) return n;
        return n * 2;
    }
}