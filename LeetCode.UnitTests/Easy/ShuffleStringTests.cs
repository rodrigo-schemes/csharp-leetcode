using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class ShuffleStringTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void ShuffleString_UnitTest(string s, int[] indices, string expected)
    {
        var result = ShuffleString.Run(s, indices);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return
        [
            "codeleet",
            new[] { 4, 5, 6, 7, 0, 2, 1, 3 },
            "leetcode"
        ];

        yield return 
        [
            "abc",
            new[] {0,1,2},
            "abc"
        ];
    }
}