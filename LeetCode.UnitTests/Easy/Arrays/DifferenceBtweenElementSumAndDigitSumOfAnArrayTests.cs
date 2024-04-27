using FluentAssertions;
using LeetCode.Easy;
using LeetCode.Easy.Arrays;

namespace LeetCode.UnitTests.Easy.Arrays;

public class DifferenceBetweenElementSumAndDigitSumOfAnArrayTests
{
    [Theory]
    [InlineData(new[] { 1, 15, 6, 3 }, 9)]
    [InlineData(new[] { 1, 2, 3, 4 }, 0)]
    [InlineData(new[] { 1, 2, 3, 10 }, 9)]
    public void DifferenceBtweenElementSumAndDigitSumOfAnArray_UnitTest(int[] nums, int expected)
    {
        var result = DifferenceBetweenElementSumAndDigitSumOfAnArray.Run(nums);
        result.Should().Be(expected);
    }
}