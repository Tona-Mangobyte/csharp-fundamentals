public class Counter 
{
    private int _count;

    public int GetNextValue()
    {
        _count++;
        return _count;
    }

    // Conversion operators | Using explicit conversion operators
    public static explicit operator int(Counter value)
    {
        return value._count;
    }

    public static explicit operator Counter(int value)
    {
        return new Counter { _count = value };
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