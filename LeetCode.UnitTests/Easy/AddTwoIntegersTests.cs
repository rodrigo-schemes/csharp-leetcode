using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class AddTwoIntegersTests
{
    [Theory]
    [InlineData(12, 5, 17)]
    [InlineData(-10, 4, -6)]
    public void AddTwoIntegers_UnitTests(int num1, int num2, int expected)
    {
        var result = AddTwoIntegers.Run(num1, num2);
        result.Should().Be(expected);
    }
}