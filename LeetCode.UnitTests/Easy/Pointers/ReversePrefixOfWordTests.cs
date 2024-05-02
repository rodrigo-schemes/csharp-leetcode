using FluentAssertions;
using LeetCode.Easy.Pointers;

namespace LeetCode.UnitTests.Easy.Pointers;

public class ReversePrefixOfWordTests
{
    [Theory]
    [InlineData("abcdefd", 'd', "dcbaefd")]
    [InlineData("xyxzxe", 'z', "zxyxxe")]
    [InlineData("abcd", 'z', "abcd")]
    public void ReversePrefixOfWord_UnitTest(string word, char ch, string expected)
    {
        var result = ReversePrefixOfWord.Run(word, ch);
        result.Should().Be(expected);
    }
}