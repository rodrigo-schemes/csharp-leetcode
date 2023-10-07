using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class NumberOfGoodPairsTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void NumberOfGoodPairs_UnitTest(int[] nums, int expected)
    {
        var result = NumberOfGoodPairs.Run(nums);
        result.Should().Be(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { new[] {1,2,3,1,1,3}, 4};
        yield return new object[] { new[] {1,1,1,1}, 6};
        yield return new object[] { new[] {1,2,3}, 0};
    }
}