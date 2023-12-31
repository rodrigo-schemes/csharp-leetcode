﻿using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class DefangingAnIpAddressTests
{
    [Theory]
    [InlineData("1.1.1.1", "1[.]1[.]1[.]1")]
    [InlineData("255.100.50.0", "255[.]100[.]50[.]0")]
    public void DefangingAnIpAddress_UnitTest(string address, string expected)
    {
        var result = DefangingAnIpAddress.Run(address);
        result.Should().Be(expected);
    }
}