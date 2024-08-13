// Defining a generic class
public class NamedContainer<T>(T item, string name)
{
    public T Item { get; } = item;
    public string Name { get; } = name;
}

// Defining a generic record
public record NamedContainerRecord<T>(T Item, string Name);
