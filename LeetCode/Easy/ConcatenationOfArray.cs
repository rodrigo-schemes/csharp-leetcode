namespace LeetCode.Easy;

public static class ConcatenationOfArray
{
    public static IEnumerable<int> Run(int[] nums)
    {
        var returnArray = new int[nums.Length * 2];

        Array.Copy(nums, 0, returnArray, 0, nums.Length);
        Array.Copy(nums, 0, returnArray, nums.Length, nums.Length);

        return returnArray;
    } 
}