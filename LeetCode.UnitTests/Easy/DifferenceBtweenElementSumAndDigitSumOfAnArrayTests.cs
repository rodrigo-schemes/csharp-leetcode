using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class DifferenceBtweenElementSumAndDigitSumOfAnArrayTests
{
    [Theory]
    [InlineData(new[] { 1, 15, 6, 3 }, 9)]
    [InlineData(new[] { 1, 2, 3, 4 }, 0)]
    [InlineData(new[] { 1, 2, 3, 10 }, 9)]
    public void DifferenceBtweenElementSumAndDigitSumOfAnArray_UnitTest(int[] nums, int expected)
    {
        var result = DifferenceBtweenElementSumAndDigitSumOfAnArray.Run(nums);
        result.Should().Be(expected);
    }
}