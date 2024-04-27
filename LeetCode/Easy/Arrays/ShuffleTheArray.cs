namespace LeetCode.Easy.Arrays;

public static class ShuffleTheArray
{
    public static IEnumerable<int> Run(int[] nums, int n)
    {
        var size = 2*n;
        var returnedArray = new int[size];
        var posArrayLeft = 0;
        var posArrayRight = n;

        for (var x = 0; x < nums.Length; x ++)
        {
            returnedArray[x] = nums[posArrayLeft];
            x++;
            returnedArray[x] = nums[posArrayRight];

            posArrayLeft++;
            posArrayRight++;
        }

        return returnedArray;
    }
}