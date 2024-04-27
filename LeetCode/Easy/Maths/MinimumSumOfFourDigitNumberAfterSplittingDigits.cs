namespace LeetCode.Easy.Maths;

public static class MinimumSumOfFourDigitNumberAfterSplittingDigits
{
    public static int Run(int num)
    {
        var sort = num.ToString().Order().ToArray();

        var num1 = int.Parse(string.Concat(sort[0], sort[2]));
        var num2 = int.Parse(string.Concat(sort[1], sort[3]));

        return num1 + num2;
    }
}