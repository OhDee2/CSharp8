namespace CSharp8.ReadonlyMembers;

/// <summary>
/// The readonly override can only be done on a struct
/// Not sure what use cases I would use structs over class for...
/// </summary>
public readonly struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; init; }
    public double Y { get; init; }

    public override string ToString() => $"({X}, {Y})";
}