namespace LeetCode.Easy;

public static class WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    public static int Run(int[][] points)
    {
        points = points
            .OrderBy(x => x[0])
            .ThenBy(y => y[1])
            .ToArray();

        var widest = 0;
        
        for (var i = points.Length - 1; i > 0; i--)
        {
            var diff = points[i][0] - points[i - 1][0];
            widest = Math.Max(widest, diff);
        }

        return widest;
    }
}