public class Item
{
    public Item(decimal price, string name)
    {
        _price = price;
        _name = name;
    }
    private readonly decimal _price;
    private readonly string _name;

    public override string ToString() => $"{_name}: {_price:C}";
}

public class ItemPrimaryConstructor(decimal price, string name)
{
    public override string ToString() => $"{name}: {price:C}";
}

// Record type with customized copy constructor
public record ItemRecord(decimal Price, string Name) {

    public ItemRecord(ItemRecord itemRecord)
    {
        Price = itemRecord.Price;
        Name = itemRecord.Name;
    }

    public override string ToString() => $"{Name}: {Price:C}";
}

public class ItemMultiConstructor
{
    public ItemMultiConstructor()
    {
        _price = 0;
        _name = "Unknown";
    }

    public ItemMultiConstructor(decimal price): this(price, "Unknown")
    {}

    public ItemMultiConstructor(decimal price, string name)
    {
        _price = price;
        _name = name;
    }
    
    private readonly decimal _price;
    private readonly string _name;

    public override string ToString() => $"{_name}: {_price:C}";
}