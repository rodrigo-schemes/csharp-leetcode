using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class CountPairsWhoseSumIsLessThanTargetTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void CountPairsWhoseSumIsLessThanTarget_UnitTest(IList<int> nums, int target, int expected)
    {
        var result = CountPairsWhoseSumIsLessThanTarget.Run(nums, target);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { -1, 1, 2, 3, 1 }, 2, 3];
        yield return [new[] { -6,2,5,-2,-7,-1,3 }, -2, 10];
    }
}