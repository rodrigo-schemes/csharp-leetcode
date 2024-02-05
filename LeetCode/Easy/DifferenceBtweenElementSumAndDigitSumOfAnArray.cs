namespace LeetCode.Easy;

public static class DifferenceBtweenElementSumAndDigitSumOfAnArray
{
    public static int Run(int[] nums)
    {
        var num1 = nums.Sum();
        var num2 = 0;
        
        foreach (var t in nums)
        {
            var temp = t;

            while (temp > 0)
            {
                num2 += temp % 10;
                temp /= 10;
            }
        }

        return num1 - num2;
    }
}