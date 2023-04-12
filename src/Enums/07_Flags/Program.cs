// Flags - это атрибут, который позволяет представлять перечисление как набор значений,
// а не одно значение

// ReSharper disable All
var employee = UserType.Driver | UserType.Admin;
WriteLine(employee);
WriteLine(UserType.Driver | UserType.Admin);
WriteLine(UserType.Driver | UserType.Customer);

//
WriteLine("*********");
employee |= UserType.Sysadmin;
WriteLine(employee);

employee &= ~UserType.Sysadmin;
WriteLine(employee);

WriteLine((employee & UserType.Driver) == UserType.Driver);
WriteLine((employee & UserType.Sysadmin) == UserType.Sysadmin);

WriteLine("*********");
ReadKey();
var audience = UserType.None;
audience.Print();
audience = audience.Add(UserType.Employee, UserType.Customer);
audience.Print();
audience = audience.Remove(UserType.Driver);
audience.Print();
if (audience.CustomHasFlag(UserType.Driver)) // или HasFlag
{
    WriteLine("Водитель имеется.");
}
else
{
    WriteLine("Водителя нет!");
    WriteLine("Добавляем его...");
    audience = audience.Add(UserType.Driver);
}
audience.Print();


ReadKey();