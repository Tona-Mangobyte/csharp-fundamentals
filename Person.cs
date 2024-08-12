public class Person
{
    private string? _name;
    public string? FavoriteColor { get; set; }

    public string? Name
    {
        get
        {
            return _name ?? "Unknown";
        }
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