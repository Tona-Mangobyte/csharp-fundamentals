public class Counter 
{
    private int _count;

    public int GetNextValue()
    {
        _count++;
        return _count;
    }
}

public class CounterWithPrimaryConstructor(int count)
{
    public int GetNextValue()
    {
        count += 1;
        return count;
    }
}

public class CounterWithTotal
{
    private int _count;
    private static int _totalCount;

    public int GetNextValue()
    {
        _count += 1;
        _totalCount += 1;
        return _count;
    }

    public static int TotalCount => _totalCount;
}