using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class FinalValueOfVariableAfterPerformingOperationsTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void FinalValueOfVariableAfterPerformingOperationsTests_UnitTest(string[] operations, int expected)
    {
        var result = FinalValueOfVariableAfterPerformingOperations.Run(operations);
        result.Should().Be(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { new[] {"--X","X++","X++"}, 1};
        yield return new object[] { new[] {"++X","++X","X++"}, 3};
        yield return new object[] { new[] {"X++","++X","--X","X--"}, 0};
    }
}

