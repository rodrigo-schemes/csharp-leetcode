using FluentAssertions;
using LeetCode.Easy.Arrays;

namespace LeetCode.UnitTests.Easy.Arrays;

public class RichCustomerWeatlhTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public static void RichCustomerWeatlhTests_UnitTest(int[][] accounts, int expected)
    {
        var result = RichestCustomerWealth.Run(accounts);
        result.Should().Be(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return [new[] { new []{1,2,3}, new []{3,2,1}}, 6];
        yield return [new[] { new []{1,5}, new []{7,3}, new []{3,5}}, 10];
        yield return [new[] { new []{2,8,7}, new []{7,1,3}, new []{1,9,5}}, 17];
    }
}