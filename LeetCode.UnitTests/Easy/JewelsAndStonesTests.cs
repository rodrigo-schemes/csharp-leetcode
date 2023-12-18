using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class JewelsAndStonesTests
{
    [Theory]
    [InlineData("aA", "aAAbbbb", 3)]
    [InlineData("z", "ZZ", 0)]
    public void JewelsAndStones_UnitTest(string jewels, string stones, int expected)
    {
        var result = JewelsAndStones.Run(jewels, stones);
        result.Should().Be(expected);
    }
}