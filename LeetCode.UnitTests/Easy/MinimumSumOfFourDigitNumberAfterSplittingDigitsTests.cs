﻿using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class MinimumSumOfFourDigitNumberAfterSplittingDigitsTests
{
    [Theory]
    [InlineData(2932, 52)]
    [InlineData(4009, 13)]
    public void MinimumSumOfFourDigitNumberAfterSplittingDigits_UnitTest(int num, int expected)
    {
        var result = MinimumSumOfFourDigitNumberAfterSplittingDigits.Run(num);
        result.Should().Be(expected);
    }
}