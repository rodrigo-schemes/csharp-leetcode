using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class CheckIfTwoStringArraysAreEquivalentTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void CheckIfTwoStringArraysAreEquivalent_UnitTest(string[] word1, string[] word2, bool expected)
    {
        var result = CheckIfTwoStringArraysAreEquivalent.Run(word1, word2);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { "ab", "c" }, new[] { "a", "bc" }, true];
        yield return [new[] { "a", "cb" }, new[] { "ab", "c" }, false];
        yield return [new[] { "abc", "d", "defg" }, new[] { "abcddefg" }, true];
    }
}