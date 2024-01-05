using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class DecompressRunLenghtEncodedListTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void DecompressRunLenghtEncodedList_UnitTest(int[] nums, int[] expected)
    {
        var result = DecompressRunLenghtEncodedList.Run(nums);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new[] { 1, 2, 3, 4 }, new[] { 2, 4, 4, 4 }];
        yield return [new[] { 1, 1, 2, 3 }, new[] { 1, 3, 3 }];
    }
}