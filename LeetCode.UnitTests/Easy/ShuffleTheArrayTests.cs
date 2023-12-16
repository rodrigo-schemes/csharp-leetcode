using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class ShuffleTheArrayTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void ShuffleTheArray_UnitTest(int[] nums, int n, int[] expected)
    {
        var result = ShuffleTheArray.Run(nums, n);
        result.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { new[]{2,5,1,3,4,7}, 3, new[]{2,3,5,4,1,7} };
        yield return new object[] { new[]{1,2,3,4,4,3,2,1}, 4, new[]{1,4,2,3,3,2,4,1} };
        yield return new object[] { new[]{1,1,2,2}, 2, new[]{1,2,1,2} };
    }
}