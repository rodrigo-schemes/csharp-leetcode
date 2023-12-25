namespace LeetCode.Easy;

public static class SubtractTheProductAndSumOfDigitsOfAnInteger
{
    public static int Run(int n)
    {
        return Product(n) - Sum(n);
    }

    private static int Product(int n) => n < 2 ? 1 : n % 10 * Product(n / 10);
    private static int Sum(int n) => n < 2 ? n : n % 10 + Sum(n / 10);
}