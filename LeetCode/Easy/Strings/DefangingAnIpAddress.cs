namespace LeetCode.Easy.Strings;

public static class DefangingAnIpAddress
{
    public static string Run(string address)
    {
        return address.Replace(".", "[.]");
    }
}