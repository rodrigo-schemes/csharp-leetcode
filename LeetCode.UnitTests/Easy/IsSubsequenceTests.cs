using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class IsSubsequenceTests
{
    [Theory]
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("axc", "ahbgdc", false)]
    public void IsSubsequence_UnitTest(string s, string t, bool expectedResult)
    {
        var result = IsSubsequence.Run(s, t);
        result.Should().Be(expectedResult);
    }
}