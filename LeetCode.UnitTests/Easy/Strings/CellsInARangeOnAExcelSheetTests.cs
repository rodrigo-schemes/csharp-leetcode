using FluentAssertions;
using LeetCode.Easy.Strings;

namespace LeetCode.UnitTests.Easy.Strings;

public class CellsInARangeOnAExcelSheetTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void CellsInARangeOnAExcelSheet_UnitTest(string s, IList<string> expected)
    {
        var result = CellsInARangeOnAExcelSheet.Run(s);
        result.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return ["K1:L2", new List<string> { "K1", "K2", "L1", "L2" }];
        yield return ["A1:F1", new List<string> { "A1", "B1", "C1", "D1", "E1", "F1" }];
    }
}