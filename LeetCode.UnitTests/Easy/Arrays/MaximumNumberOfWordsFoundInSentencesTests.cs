using FluentAssertions;
using LeetCode.Easy.Arrays;

namespace LeetCode.UnitTests.Easy.Arrays;

public class MaximumNumberOfWordsFoundInSentencesTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void MaximumNumberOfWordsFoundInSentences_UnitTest(string[] sentences, int expected)
    {
        var result = MaximumNumberOfWordsFoundInSentences.Run(sentences);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { "please wait", "continue to fight", "continue to win" }, 3];
        yield return [new[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }, 6];
    }
}