using FluentAssertions;
using LeetCode.Easy.Arrays;

namespace LeetCode.UnitTests.Easy.Arrays;

public class ConcatenationOfArrayTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void ConcatenationOfArray_UnitTest(int[] nums, int[] expected)
    {
        var result = ConcatenationOfArray.Run(nums);
        result.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] 
        {
            new []{1,2,1}, 
            new []{1,2,1,1,2,1}
        };
        yield return new object[]
        {
            new []{1,3,2,1},
            new []{1,3,2,1,1,3,2,1}
        };
    }
}