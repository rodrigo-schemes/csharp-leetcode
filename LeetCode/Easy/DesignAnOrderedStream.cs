namespace LeetCode.Easy;

public static class DesignAnOrderedStream
{
    public static List<string> Run()
    {
        var stream = new List<IList<string>>();
        
        var os = new OrderedStream();
        stream.Add(os.Insert(3, "ccccc"));
        stream.Add(os.Insert(1, "aaaaa"));
        stream.Add(os.Insert(2, "bbbbb"));
        stream.Add(os.Insert(5, "eeeee"));
        stream.Add(os.Insert(4, "ddddd"));

        return FlattenList(stream);
    }

    private static List<string> FlattenList(List<IList<string>> listOfLists)
    {
        var flattenedList = new List<string>();

        foreach (var list in listOfLists)
        {
            flattenedList.AddRange(list);
        }

        return flattenedList;
    }
}

public class OrderedStream
{
    private int _nextId;
    private readonly Dictionary<int, string> _guard;
    public OrderedStream()
    {
        _nextId = 1;
        _guard = new Dictionary<int, string>();
    }

    public IList<string> Insert(int idKey, string value)
    {
        var stream = new List<string>();

        if (idKey == _nextId)
        {
            stream.Add(value);
            _nextId++;
        }

        while (true)
        {
            if (!_guard.TryGetValue(_nextId, out var chunk))
            {
                _guard.Add(idKey, value);
                break;
            }
            stream.Add(chunk);
            _nextId++;
        }
        
        return stream;
    }
}
