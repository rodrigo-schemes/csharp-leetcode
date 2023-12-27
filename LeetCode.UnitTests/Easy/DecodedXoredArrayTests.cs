using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class DecodedXoredArrayTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void DecodedXoredArray_UnitTest(int[] encoded, int first, int[] expected)
    {
        var result = DecodedXoredArray.Run(encoded, first);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { 1, 2, 3 }, 1, new[] { 1, 0, 2, 1 }];
        yield return [new[] { 6, 2, 7, 3 }, 4, new[] { 4, 2, 0, 7, 4 }];
    }
}