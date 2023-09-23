namespace LeetCode.Easy;

public static class NumberOfStepsToReduceANumberToZero
{
    public static int Run(int num)
    {
        var numberOfSteps = 0;

        while (num > 0)
        {
            if (num % 2 == 0) num /= 2;
            else num -= 1;

            numberOfSteps++;
        }

        return numberOfSteps;
    }
}