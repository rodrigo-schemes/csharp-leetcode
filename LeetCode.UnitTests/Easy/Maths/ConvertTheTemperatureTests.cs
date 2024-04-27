using FluentAssertions;
using LeetCode.Easy.Maths;

namespace LeetCode.UnitTests.Easy.Maths;

public class ConvertTheTemperatureTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void ConvertTheTemperatureTests_UnitTest(double celsius, double[] expected)
    {
        var result = ConvertTheTemperature.Run(celsius);
        result.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { 36.50, new[] {309.65000, 97.70000}};
        yield return new object[] { 122.11, new[] {395.26000, 251.79800}};
    }
}