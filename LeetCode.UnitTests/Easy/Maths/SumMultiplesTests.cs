using FluentAssertions;
using LeetCode.Easy.Maths;

namespace LeetCode.UnitTests.Easy.Maths;

public class SumMultiplesTests
{
    [Theory]
    [InlineData(7,21)]
    [InlineData(10,40)]
    [InlineData(9,30)]
    public void SumMultiples_UnitTest(int n, int expected)
    {
        var result = SumMultiples.Run(n);
        result.Should().Be(expected);
    }
}