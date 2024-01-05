using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class SplitAStringInBalancedStringsTests
{
    [Theory]
    [InlineData("RLRRLLRLRL", 4)]
    [InlineData("RLRRRLLRLL", 2)]
    [InlineData("LLLLRRRR", 1)]
    public void SplitAStringInBalancedStrings_UnitTest(string s, int expected)
    {
        var result = SplitAStringInBalancedStrings.Run(s);
        result.Should().Be(expected);
    }
}