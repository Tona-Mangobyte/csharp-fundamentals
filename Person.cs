public class Person
{
    private string? _name;
    public string? FavoriteColor { get; set; } // auto-implemented property

    public string? FullName { get; private set; } // auto-implemented property with private setter

    public string? FullNameRead { get; } // auto-implemented property with no setter

    public string? Name
    {
        get => _name ?? "Unknown"; // expression-bodied getter
        set
        {
            _name = value;
        }
    }
}

public class PersonInitializationConstructor(string? name, string? favoriteColor)
{
    public string? Name = name;
    public string? FavoriteColor = favoriteColor;
}

public record PersonPrimaryConstructor(string Name, string FavoriteColor);

public record PersonModifiableProperties(string Name, string FavoriteColor)
{
    public string Name { get; set; } = Name;
    public string FavoriteColor { get; set; } = FavoriteColor;
}

// Required properties
internal class PersonRequired
{

    public required string Name { get; init; }
    public required string FavoriteColor { get; set; }
}