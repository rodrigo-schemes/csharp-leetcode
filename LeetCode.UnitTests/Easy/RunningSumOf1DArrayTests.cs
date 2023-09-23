using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class RunningSumOf1DArrayTests
{
    [Theory]
    [MemberData(nameof(Data))]

    public void RunningSumOf1DArray_UnitTest(int[] nums, int[] expectedResult)
    {
        var result = RunningSumOf1DArray.Run(nums);
        result.Should().BeEquivalentTo(expectedResult);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { new[] {1,2,3,4}, new[] {1,3,6,10} };
        yield return new object[] { new[] {1,1,1,1}, new[] {1,2,3,4} };
        yield return new object[] { new[] {3,1,2,10,1}, new[] {3,4,6,16,17} };
    }
}