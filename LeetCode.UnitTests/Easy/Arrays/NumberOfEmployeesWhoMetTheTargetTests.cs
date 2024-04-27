using FluentAssertions;
using LeetCode.Easy.Arrays;

namespace LeetCode.UnitTests.Easy.Arrays;

public class NumberOfEmployeesWhoMetTheTargetTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void NumberOfEmployeesWhoMetTheTarget_UnitTest(int[] hours, int target, int expected)
    {
        var result = NumberOfEmployeesWhoMetTheTarget.Run(hours, target);
        result.Should().Be(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { new []{0,1,2,3,4}, 2, 3 };
        yield return new object[] { new []{5,1,4,2,2}, 6, 0 };
    }
}