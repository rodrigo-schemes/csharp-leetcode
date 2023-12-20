namespace LeetCode.Easy;

public static class NumberOfEmployeesWhoMetTheTarget
{
    public static int Run(IEnumerable<int> hours, int target)
    {
        return hours.Count(h => h >= target);
    }
}