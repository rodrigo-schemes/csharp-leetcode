namespace LeetCode.Easy.Arrays;

public static class FinalValueOfVariableAfterPerformingOperations
{
    public static int Run(IEnumerable<string> operations)
    {
        var output = 0;
        
        foreach (var t in operations)
        {
            if (t.Contains("--"))
            {
                output -= 1;
                continue;
            }

            output++;
        }

        return output;
    }
}