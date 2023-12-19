using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class FindWordsContainingCharacterTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void FindWordsContainingCharacter_UnitTest(string[] words, char x, int[] expected)
    {
        var result = FindWordsContainingCharacter.Run(words, x);
        result.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { new[]{"leet","code"}, 'e', new[]{0,1} };
        yield return new object[] { new[]{"abc","bcd","aaaa","cbc"}, 'a', new[]{0,2} };
        yield return new object[] { new[]{"abc","bcd","aaaa","cbc"}, 'z', Array.Empty<int>() };
    }
}