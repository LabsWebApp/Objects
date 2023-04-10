var now = DateTime.Now;

Console.WriteLine($"Дата месяц(прописью) год : {now:D}");
Console.WriteLine($"Дата.месяц.год : {now:d}");
Console.WriteLine($"Дата месяц(прописью) год время(чч:мм:сс) : {now:F}");
Console.WriteLine($"Дата месяц(прописью) год время(чч:мм) : {now:f}");
Console.WriteLine($"Дата.месяц.год время(чч:мм:cc) : {now:G}");
Console.WriteLine($"Дата.месяц.год время(чч:мм) : {now:g}");
Console.WriteLine($"Текущий месяц и дата : {now:M}");
Console.WriteLine($"Текущий месяц и год : {now:Y}");
Console.WriteLine($"Время(чч:мм:cc) : {now:T}");
Console.WriteLine($"Время(чч:мм) : {now:t}");

// Delay.
Console.ReadKey();