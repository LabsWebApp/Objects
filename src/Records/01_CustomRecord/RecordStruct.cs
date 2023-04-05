namespace CustomRecord;

public readonly struct RecordStruct : IEquatable<RecordStruct>
{
    public readonly int Id;
    public readonly string Name;

    public RecordStruct(int id, string name)
    {
        Id = id;
        Name = name ?? string.Empty;
    }

    public bool Equals(RecordStruct other) => Equals(Id, other.Id) && Equals(Name, other.Name);

    public override bool Equals(object? obj) =>
        obj is { } && (obj.GetType() == this.GetType() && Equals((RecordStruct)obj));

    public static bool operator ==(RecordStruct? left, RecordStruct? right) =>
        (left, right) switch
        {
            (null, _) or (_, null) => false,
            _ => left.Equals(right),
        };

    public static bool operator !=(RecordStruct? left, RecordStruct? right) => !(left == right);

    public override int GetHashCode() => HashCode.Combine(Id, Name);

    public override string ToString() => $"{this.GetType().Name} {{Id = {Id}, Name = {Name}}}";
}