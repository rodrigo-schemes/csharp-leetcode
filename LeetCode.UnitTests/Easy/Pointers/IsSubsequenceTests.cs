using FluentAssertions;
using LeetCode.Easy.Pointers;

namespace LeetCode.UnitTests.Easy.Pointers;

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