using FluentAssertions;
using LeetCode.Easy.Maths;

namespace LeetCode.UnitTests.Easy.Maths;

public class SubtractTheProductAndSumOfDigitsOfAnIntegerTests
{
    [Theory]
    [InlineData(234, 15)]
    [InlineData(4421, 21)]
    public void SubtractTheProductAndSumOfDigitsOfAnInteger_UnitTest(int n, int expected)
    {
        var result = SubtractTheProductAndSumOfDigitsOfAnInteger.Run(n);
        result.Should().Be(expected);
    }
}