namespace CustomRecord;

public static class WithExtensions
{
    public static RecordClass With(this RecordClass record, int id) => new(id, record.Name);
    public static RecordClass With(this RecordClass record, string name) => new(record.Id, name);

    public static RecordStruct With(this RecordStruct record, string name) => new(record.Id, name);
    public static RecordStruct With(this RecordStruct record, int id) => new(id, record.Name);
}