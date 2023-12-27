using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class SumOfValuesAtIndicesWithKSetBitsTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void SumOfValuesAtIndicesWithKSetBits_UnitTest(IList<int> nums, int k, int expected)
    {
        var result = SumOfValuesAtIndicesWithKSetBits.Run(nums, k);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new List<int> { 5, 10, 1, 5, 2 }, 1, 13];
        yield return [new List<int> { 4, 3, 2, 1 }, 2, 1];
        
    }
}

