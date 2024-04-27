namespace LeetCode.Easy.Maths;

public static class ConvertTheTemperature
{
    public static double[] Run(double celsius)
    {
        var kelvin = celsius + 273.15;
        var fahrenheit = celsius * 1.8 + 32;

        return new[] { kelvin, fahrenheit };
    }
}