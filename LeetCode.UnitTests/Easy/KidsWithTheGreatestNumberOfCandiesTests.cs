using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class KidsWithTheGreatestNumberOfCandiesTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void KidsWithTheGreatestNumberOfCandies_UnitTest(int[] candies, int extraCandies, IEnumerable<bool> expected)
    {
        var result = KidsWithTheGreatestNumberOfCandies.Run(candies, extraCandies);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { 2, 3, 5, 1, 3 }, 3, new List<bool> { true, true, true, false, true }];
        yield return [new[] { 4, 2, 1, 1, 2 }, 1, new List<bool> { true, false, false, false, false }];
        yield return [new[] { 12, 1, 12 }, 10, new List<bool> { true, false, true }];
    }
}