namespace LeetCode.Easy;

public static class FizzBuzz
{
    public static IEnumerable<string> Run(int n)
    {
        var fizzbuzz = new List<string>();
        
        for (var i = 1; i <= n; i++)
        {
            switch (i % 3)
            {
                case 0 when i % 5 == 0:
                    fizzbuzz.Add("FizzBuzz");
                    break;
                case 0:
                    fizzbuzz.Add("Fizz");
                    break;
                default:
                {
                    fizzbuzz.Add(i % 5 == 0 ? "Buzz" : i.ToString());
                    break;
                }
            }
        }

        return fizzbuzz;
    }
}