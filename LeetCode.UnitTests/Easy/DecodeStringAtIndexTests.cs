using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class DecodeStringAtIndexTests
{
    [Theory]
    [InlineData("leet2code3", 10, "o")]
    [InlineData("ha22", 5, "h")]
    [InlineData("a2345678999999999999999", 1, "a")]
    [InlineData("y959q969u3hb22odq595", 222280369, "y")]
    public void DecodedStringAtIndex_UnitTest(string s, int k, string expected)
    {
        var result = DecodedStringAtIndex.Run(s, k);
        result.Should().Be(expected);
    }
}