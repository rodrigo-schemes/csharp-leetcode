using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class DesignAnOrderedStreamTests
{
    [Fact]
    public void DesignAnOrderedStream_UnitTest()
    {
        var expected = new List<string>
        {
            "aaaaa", "bbbbb", "ccccc", "ddddd", "eeeee"
        };
        
        var result = DesignAnOrderedStream.Run();
        result.Should().BeEquivalentTo(expected);
    }
}