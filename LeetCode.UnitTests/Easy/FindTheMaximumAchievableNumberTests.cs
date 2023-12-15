using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class FindTheMaximumAchievableNumberTests
{
    [Theory]
    [InlineData(4, 1, 6)]
    [InlineData(3, 2, 7)]
    public void FindTheMaximumAchievableNumber_UnitTest(int num, int t, int expected)
    {
        var result = FindTheMaximumAchievableNumber.Run(num, t);
        result.Should().Be(expected);
    }
}