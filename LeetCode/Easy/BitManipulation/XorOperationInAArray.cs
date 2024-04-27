namespace LeetCode.Easy.BitManipulation;

public static class XorOperationInAArray
{
    public static int Run(int n, int start)
    {
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            result ^= start + 2 * i;
        }
        
        return result;
    }
}