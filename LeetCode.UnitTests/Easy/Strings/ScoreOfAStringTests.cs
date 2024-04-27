using FluentAssertions;
using LeetCode.Easy.Strings;

namespace LeetCode.UnitTests.Easy.Strings;

public class ScoreOfAStringTests
{
    [Theory]
    [InlineData("hello", 13)]
    [InlineData("zaz", 50)]
    public void ScoreOfAString_UnitTest(string s, int expected)
    {
        var result = ScoreOfAString.Run(s);
        result.Should().Be(expected);
    }
}