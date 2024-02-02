namespace LeetCode.Easy;

public static class CellsInARangeOnAExcelSheet
{
    public static IList<string> Run(string s)
    {
        var firstChar = s[0];
        var lastChar = s[3];
        var firstDigit = s[1];
        var lastDigit = s[4];
        
        var firstRow = (int)char.GetNumericValue(firstDigit);
        var lastRow = (int)char.GetNumericValue(lastDigit);

        var minRow = Math.Min(firstRow, lastRow);
        var maxRow = Math.Max(firstRow, lastRow);
        
        var result = new List<string>();

        for (var letter = firstChar; letter <= lastChar; letter++)
        {
            for (var row = minRow; row <= maxRow; row++)
            {
                result.Add($"{letter}{row}");    
            }
        }

        return result;
    }
}