using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class TruncateSentenceTests
{
    [Theory]
    [InlineData("Hello how are you Contestant", 4, "Hello how are you")]
    [InlineData("What is the solution to this problem", 4, "What is the solution")]
    public void TruncateSentence_UnitTest(string s, int k, string expected)
    {
        var result = TruncateSentence.Run(s, k);
        result.Should().Be(expected);
    }
}