namespace LeetCode.Easy;

public static class DecodedXoredArray
{
    public static int[] Run(int[] encoded, int first)
    {
        var store = new List<int> { first };

        for (var i = 0; i < encoded.Length; i++)
        {
            store.Add(store[i] ^ encoded[i]);
        }

        return store.ToArray();
    }
}