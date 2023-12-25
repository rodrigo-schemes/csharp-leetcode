namespace LeetCode.Easy;

public static class KidsWithTheGreatestNumberOfCandies
{
    public static IEnumerable<bool> Run(int[] candies, int extraCandies)
    {
        var biggest = candies.Max();

        return candies.Select(candy => candy + extraCandies >= biggest).ToList();
    }
}