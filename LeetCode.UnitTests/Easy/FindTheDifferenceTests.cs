using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class FindTheDifferenceTests
{
    [Theory]
    [InlineData("abcd", "abcde", 'e')]
    [InlineData("raul", "luara", 'a')]
    [InlineData("", "y", 'y')]
    public void FindTheDifference_UnitTest(string s, string t, char expected)
    {
        var result = FindTheDifference.Run(s, t);
        result.Should().Be(expected);
    }
}