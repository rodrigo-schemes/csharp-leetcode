using FluentAssertions;
using LeetCode.Easy.Arrays;

namespace LeetCode.UnitTests.Easy.Arrays;

public class LeftAndRightDifferencesTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void LeftAndRightDifferences_UnitTest(int[] nums, int[] expected)
    {
        var result = LeftAndRightDifferences.Run(nums);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { 10, 4, 8, 3 }, new[] { 15, 1, 11, 22 }];
        yield return [new[] { 1 }, new[] { 0 }];
    }
}