namespace LeetCode.Easy;

public static class MinimumNumberGame
{
    public static IEnumerable<int> Run(int[] nums)
    {
        var arr = new int[nums.Length];

        var orderedArr = nums.Order().ToArray();

        for (var i = 0; i <= orderedArr.Length; i++)
        {
            if (i % 2 == 0) continue;
            
            arr[i - 1] = orderedArr[i];
            arr[i] = orderedArr[i - 1];
        }

        return arr;
    }
}