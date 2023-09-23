namespace LeetCode.Easy;

public static class RichestCustomerWealth
{
    public static int Run(IEnumerable<int[]> accounts)
    {
        var maxWealth = 0;

        foreach (var account in accounts)
        {
            var currentCustomerWealth = 0;

            foreach (var salary in account)
            {
                currentCustomerWealth += salary;
            }

            maxWealth = Math.Max(maxWealth, currentCustomerWealth);
        }

        return maxWealth;
    }
}