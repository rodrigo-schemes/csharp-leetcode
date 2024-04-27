using FluentAssertions;
using LeetCode.Easy.Maths;

namespace LeetCode.UnitTests.Easy.Maths;

public class DivisibleAndNonDivisibleSumsDifferenceTests
{
    [Theory]
    [InlineData(10, 3, 19)]
    [InlineData(5, 6, 15)]
    [InlineData(5, 1, -15)]
    public void DivisibleAndNonDivisibleSumsDifference_UnitTest(int n, int m, int expected)
    {
        var result = DivisibleAndNonDivisibleSumsDifference.Run(n, m);
        result.Should().Be(expected);
    }
}