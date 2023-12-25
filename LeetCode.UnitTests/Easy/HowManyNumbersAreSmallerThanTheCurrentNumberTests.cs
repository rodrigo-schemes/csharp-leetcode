using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class HowManyNumbersAreSmallerThanTheCurrentNumberTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void HowManyNumbersAreSmallerThanTheCurrentNumber_UnitTest(int[] nums, int[] expected)
    {
        var result = HowManyNumbersAreSmallerThanTheCurrentNumber.Run(nums);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { 8, 1, 2, 2, 3 }, new[] { 4, 0, 1, 1, 3 }];
        yield return [new[] { 6, 5, 4, 8 }, new[] { 2, 1, 0, 3 }];
        yield return [new[] { 7, 7, 7, 7 }, new[] { 0, 0, 0, 0 }];
    }
}