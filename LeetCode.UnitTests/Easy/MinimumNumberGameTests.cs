using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class MinimumNumberGameTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void MinimumNumberGame_UnitTest(int[] nums, int[] expected)
    {
        var result = MinimumNumberGame.Run(nums);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { 5, 4, 2, 3 }, new[] { 3, 2, 5, 4 }];
        yield return [new[] { 2, 5 }, new[] { 5, 2 }];
    }
}