public readonly struct PointStruct(double x, double y)
{
    public double X => x;
    public double Y => y;

    public double DistanceFromOrigin() => Math.Sqrt(X * X + Y * Y);
}

// Support custom comparison
public readonly struct PointStructComparison(double x, double y) : IEquatable<PointStructComparison>
{
    public double X => x;
    public double Y => y;

    public double DistanceFromOrigin() => Math.Sqrt(X * X + Y * Y);

    public override bool Equals(object? o) => o is PointStructComparison p && this.Equals(p);
    public bool Equals(PointStructComparison o) => this.X == o.X && this.Y == o.Y;

    public override int GetHashCode() => HashCode.Combine(X, Y);

    public static bool operator ==(PointStructComparison a, PointStructComparison b) => a.Equals(b);
    public static bool operator !=(PointStructComparison a, PointStructComparison b) => !(a == b);
}

public record PointRecord(int X, int Y);
public record struct PointStructRecord(int X, int Y);
public readonly record struct PointReadonlyStructRecord(int X, int Y);

public readonly struct PointInit(double x, double y)
{
    public double X { get; init; } = x;
    public double Y { get; init; } = y;
}