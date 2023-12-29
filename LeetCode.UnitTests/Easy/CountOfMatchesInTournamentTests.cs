using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class CountOfMatchesInTournamentTests
{
    [Theory]
    [InlineData(8, 7)]
    [InlineData(7, 6)]
    [InlineData(2, 1)]
    [InlineData(14, 13)]
    public void CountOfMatchesInTournament_UnitTest(int n, int expected)
    {
        var result = CountOfMatchesInTournament.Run(n);
        result.Should().Be(expected);
    }
}