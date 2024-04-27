using FluentAssertions;
using LeetCode.Easy.Maths;

namespace LeetCode.UnitTests.Easy.Maths;

public class SmallestEvenMultipleTests
{
    [Theory]
    [InlineData(5, 10)]
    [InlineData(6, 6)]
    public void SmallestEvenMultiple_UnitTest(int n, int expected)
    {
        var result = SmallestEvenMultiple.Run(n);
        result.Should().Be(expected);
    }
}