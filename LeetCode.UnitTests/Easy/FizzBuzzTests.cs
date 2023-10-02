using FluentAssertions;
using LeetCode.Easy;

namespace LeetCode.UnitTests.Easy;

public class FizzBuzzTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void FizzBuzz_UnitTest(int n, List<string> expected)
    {
        var result = FizzBuzz.Run(n);
        result.Should().BeEquivalentTo(expected);
    }
    
    public static IEnumerable<object[]> Data(){
        yield return new object[] { 3, new List<string> { "1", "2", "Fizz"} };
        yield return new object[] { 5, new List<string> { "1", "2", "Fizz", "4", "Buzz"} };
        yield return new object[] { 15, new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", 
            "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"} };
        yield return new object[] { 20, new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", 
            "Buzz", "11", "Fizz", "13", "14", "FizzBuzz","16","17","Fizz","19","Buzz"} };
    }
}