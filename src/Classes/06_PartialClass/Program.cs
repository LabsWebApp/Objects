using Classes;

PartialClass instance = new PartialClass(); // Конструктор из нулевой части класса PartialClass

instance.MethodFromPart1(); // Метод из первой части класса PartialClass
instance.MethodFromPart2(); // Метод со второй части класса PartialClass.

Console.WriteLine();

instance.CallPartialMethod(); //  Вызов частичного метода

Console.ReadKey();