using FluentAssertions;
using LeetCode.Easy.Maths;

namespace LeetCode.UnitTests.Easy.Maths;

public class PalindromeNumberTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(65256, true )]
    public void PalindromeNumber_UnitTest(int x, bool expected)
    {
        var result = PalindromeNumber.Run(x);
        result.Should().Be(expected);
    }
}