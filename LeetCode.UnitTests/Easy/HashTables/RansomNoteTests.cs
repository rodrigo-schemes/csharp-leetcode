using FluentAssertions;
using LeetCode.Easy.HashTables;

namespace LeetCode.UnitTests.Easy.HashTables;

public class RansomNoteTests
{
    [Theory]
    [InlineData("ab", "a", false)]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    public void RansomNote_UnitTest(string ransomNote, string magazine, bool expected)
    {
        var result = RansomNote.Run(ransomNote, magazine);
        result.Should().Be(expected);
    }
}