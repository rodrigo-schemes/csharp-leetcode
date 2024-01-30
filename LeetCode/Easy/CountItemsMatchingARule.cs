namespace LeetCode.Easy;

public static class CountItemsMatchingARule
{
    public static int Run(IEnumerable<IList<string>> items, string ruleKey, string ruleValue)
    {
        var ruleKeyDictionary = new Dictionary<string, int>
        {
            { "type", 0 },
            { "color", 1 },
            { "name", 2 }
        };

        return items.Count(t => t[ruleKeyDictionary[ruleKey]] == ruleValue);
    }
}