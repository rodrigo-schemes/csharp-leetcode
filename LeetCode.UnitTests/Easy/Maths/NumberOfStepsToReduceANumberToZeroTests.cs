using FluentAssertions;
using LeetCode.Easy.Maths;

namespace LeetCode.UnitTests.Easy.Maths;

public class NumberOfStepsToReduceANumberToZeroTests
{
    [Theory]
    [InlineData(14, 6)]
    [InlineData(8, 4)]
    [InlineData(123, 12)]
    public void NumberOfStepsToReduceANumberToZero_UnitTests(int num, int expected)
    {
        var result = NumberOfStepsToReduceANumberToZero.Run(num);
        result.Should().Be(expected);
    }
}