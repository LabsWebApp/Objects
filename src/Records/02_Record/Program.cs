var recClass = new RecordClass(1, "name");
var recClass1 = new RecordClass(1, "name");

Console.WriteLine(recClass);
Console.WriteLine(recClass == recClass1);
recClass1 = recClass with { Id = 666 };

Console.WriteLine(recClass1);
Console.WriteLine(recClass == recClass1);

var recStruct = new RecordStruct(1, "name");
Console.WriteLine(recStruct);



Console.ReadKey();


internal record /*class*/ RecordClass(int Id, string Name);

internal record struct RecordStruct(int Id, string Name);