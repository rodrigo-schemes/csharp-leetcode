namespace LeetCode.Easy.Maths;

public static class CountTheDigitsThatDivideANumber
{
    public static int Run(int num)
    {
        var count = 0;
        var originalNum = num;

        while (num > 0)
        {
            var digit = num % 10;

            if (originalNum % digit == 0) 
                count++;

            num /= 10;
        }
        
        return count;
    }
}