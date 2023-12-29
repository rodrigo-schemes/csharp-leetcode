using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class CreateTargetArrayInTheGivenOrderTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void CreateTargetArrayInTheGivenOrder_UnitTest(int[] nums, int[] index, int[] expected)
    {
        var result = CreateTargetArrayInTheGivenOrder.Run(nums, index);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return
        [
            new[] { 0, 1, 2, 3, 4 }, new[] { 0, 1, 2, 2, 1 }, new[] { 0, 4, 1, 3, 2 }
        ];

        yield return
        [
            new[] { 1, 2, 3, 4, 0 }, new[] { 0, 1, 2, 3, 0 }, new[] { 0, 1, 2, 3, 4 },
        ];

        yield return
        [
            new[] { 1 }, new[] { 0 }, new[] { 1 }
        ];
    }
}