namespace CustomRecord;

public class RecordClass : IEquatable<RecordClass>
{
    public int Id { get; init; }
    public string Name { get; init; }

    public RecordClass(int id, string? name)
    {
        Id = id;
        Name = name ?? string.Empty;
    }

    public bool Equals(RecordClass? other) =>
        other is not null && (Equals(Id, other.Id) && Equals(Name, other.Name));

    public override bool Equals(object? obj) =>
        obj is { } &&
        (ReferenceEquals(this, obj) || obj.GetType() == 
            this.GetType() && Equals((RecordClass)obj));

    public static bool operator ==(RecordClass? left, RecordClass? right) => 
        (left, right) switch
        {
            (null, _) or (_, null) => false,
            _ => left.Equals(right),
        };

    public static bool operator ==(RecordClass? left, object? right)
        => left == right as RecordClass;

    public static bool operator ==(object? left, RecordClass? right)
        => left as RecordClass == right;

    public static bool operator !=(RecordClass? left, RecordClass? right) => !(left == right);

    public static bool operator !=(RecordClass? left, object? right) => !(left == right);

    public static bool operator !=(object? left, RecordClass? right) => !(left == right);

    public override int GetHashCode() => HashCode.Combine(Id, Name);

    public override string ToString() => $"{this.GetType().Name} {{Id = {Id}, Name = {Name}}}";
}