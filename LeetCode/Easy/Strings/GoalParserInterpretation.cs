namespace LeetCode.Easy.Strings;

public static class GoalParserInterpretation
{
    public static string Run(string command)
    {
        var result = string.Empty;
        var compare = string.Empty;
        
        foreach (var letter in command)
        {
            compare += letter;

            switch (compare)
            {
                case "G":
                    result += "G";
                    break;
                case "()":
                    result += "o";
                    break;
                case "(al)":
                    result += "al";
                    break;
                default:
                    continue;
            }

            compare = string.Empty;
        }

        return result;
    }
}