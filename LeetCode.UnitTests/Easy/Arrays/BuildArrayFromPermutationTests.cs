using FluentAssertions;
using LeetCode.Easy.Arrays;

namespace LeetCode.UnitTests.Easy.Arrays;

public class BuildArrayFromPermutationTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void BuildArrayFromPermutation_UnitTest(int[] nums, int[] expected)
    {
        var result = BuildArrayFromPermutation.Run(nums);
        result.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { new[] {0, 2, 1, 5, 3, 4}, new[] {0, 1, 2, 4, 5, 3}};
        yield return new object[] { new[] {5, 0, 1, 2, 3, 4}, new[] {4, 5, 0, 1, 2, 3}};
    }
}