﻿using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class XorOperationInAArrayTests
{
    [Theory]
    [InlineData(5,0,8)]
    [InlineData(4,3,8)]
    public void XorOperationInAArray_UnitTest(int n, int start, int expected)
    {
        var result = XorOperationInAArray.Run(n, start);
        result.Should().Be(expected);
    }
}