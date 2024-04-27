using FluentAssertions;
using LeetCode.Easy.Arrays;

namespace LeetCode.UnitTests.Easy.Arrays;

public class WidestVerticalAreaBetweenTwoPointsContainingNoPointsTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void WidestVerticalAreaBetweenTwoPointsContainingNoPoints_UnitTest(int[][] points, int expected)
    {
        var result = WidestVerticalAreaBetweenTwoPointsContainingNoPoints.Run(points);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return [new int[][]{ [8,7], [9,9], [7,4], [9,7] }, 1];
        yield return [new int[][]{ [3,1], [9,0], [1,0], [1,4], [5,3], [8,8] }, 3];
        yield return [new int[][]{ [2, 4], [10, 10], [6, 8], [6, 8], [6, 10], [8, 6], [5, 3]}, 3];
    }
}