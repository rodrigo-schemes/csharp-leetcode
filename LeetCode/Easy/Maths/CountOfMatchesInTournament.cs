namespace LeetCode.Easy.Maths;

public static class CountOfMatchesInTournament
{
    public static int Run(int n)
    {
        var result = 0;

        if (n < 2) return result;

        if (n % 2 == 0)
        {
            result += n/2 + Run(n/2);
        }
        else
        {
            var x = (n-1)/2;
            result += x + Run(x + 1);
        }

        return result;
    }
}