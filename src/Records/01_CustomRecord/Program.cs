using CustomRecord;




//var a = new Struct { Name = "name" };
//var b = new Struct { Name = "name" };

//Console.WriteLine(a.Equals(b));
//Console.WriteLine(a.GetHashCode() + " " + b.GetHashCode());

//Console.ReadKey();














var recClass = new RecordClass(1, "name");
object recClass1 = new RecordClass(1, "name");
Console.WriteLine(recClass);
Console.WriteLine(recClass.Equals(recClass1));
Console.WriteLine(recClass == recClass1);

Console.WriteLine();

recClass1 = recClass.With("new name");
Console.WriteLine(recClass1);
Console.WriteLine(recClass.Equals(recClass1));
Console.WriteLine(recClass == recClass1);

// recClass = recClass with { Name = "new" };


var recStruct = new RecordStruct(1, "name");
Console.WriteLine(recStruct.With("new name"));

Console.WriteLine(recStruct.Equals(recClass));

Console.ReadKey();













internal struct Struct { public string Name { get; init; } }