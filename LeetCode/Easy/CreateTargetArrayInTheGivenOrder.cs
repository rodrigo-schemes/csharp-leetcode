namespace LeetCode.Easy;

public static class CreateTargetArrayInTheGivenOrder
{
    public static int[] Run(int[] nums, int[] index)
    {
        var result = new List<int>();

        for(var i = 0; i < nums.Length; i ++)
        {
            result.Insert(index[i], nums[i]);
        }

        return result.ToArray();
    }
}