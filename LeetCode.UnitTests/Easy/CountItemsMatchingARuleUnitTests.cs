using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class CountItemsMatchingARuleUnitTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void CountItemsMatchingARule_UnitTest(IList<IList<string>> items, string ruleKey, string ruleValue, int expected)
    {
        var result = CountItemsMatchingARule.Run(items, ruleKey, ruleValue);
        result.Should().Be(expected);
    }

    public static IEnumerable<object[]> Data()
    {
        yield return
            [ 
                new[]
                {
                    new[]{"phone", "blue", "pixel"}, 
                    new[]{"computer", "silver", "lenovo"}, 
                    new[]{"phone", "gold", "iphone"}
                },
                "color",
                "silver",
                1
            ];
        
        yield return
        [ 
            new[]
            {
                new[]{"phone", "blue", "pixel"}, 
                new[]{"computer", "silver", "phone"}, 
                new[]{"phone", "gold", "iphone"}
            },
            "type",
            "phone",
            2
        ];
    }
}