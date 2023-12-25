using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class GoalParserInterpretationTests
{
    [Theory]
    [InlineData("G()(al)", "Goal")]
    [InlineData("G()()()()(al)", "Gooooal")]
    [InlineData("(al)G(al)()()G", "alGalooG")]
    public void GoalParserInterpretation_UnitTest(string command, string expected)
    {
        var result = GoalParserInterpretation.Run(command);
        result.Should().BeEquivalentTo(expected);
    }
}