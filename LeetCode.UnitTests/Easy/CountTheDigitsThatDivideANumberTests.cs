using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class CountTheDigitsThatDivideANumberTests
{
    [Theory]
    [InlineData(7,1)]
    [InlineData(121,2)]
    [InlineData(1248,4)]
    public void CountTheDigitsThatDivideANumber_UnitTest(int num, int expected)
    {
        var result = CountTheDigitsThatDivideANumber.Run(num);
        result.Should().Be(expected);
    }
}