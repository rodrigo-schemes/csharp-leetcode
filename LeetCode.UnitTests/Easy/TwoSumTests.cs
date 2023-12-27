using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class TwoSumTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void TwoSum_UnitTest(int[] nums, int target, IEnumerable<int> expected)
    {
        var result = TwoSum.Run(nums, target);
        result.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return [new[] {2,7,11,15}, 9, new[] {0,1}];
        yield return [new[] {3,2,4}, 6, new[] {1,2}];
        yield return [new[] {3,3}, 6, new[] {0,1}];
        yield return [new[] {1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1}, 11, new[] {5,11}];
    }
}