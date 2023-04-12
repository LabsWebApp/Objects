var now = DateTime.Now;

Console.WriteLine($"Дата месяц(прописью) год : {now:D}");
Console.WriteLine($"Дата.месяц.год : {now:d}");
Console.WriteLine($"Дата месяц(прописью) год время(чч:мм:сс) : {now:F}");
Console.WriteLine($"Дата месяц(прописью) год время(чч:мм) : {now:f}");
Console.WriteLine($"Дата.месяц.год время(чч:мм:cc) : {now:G}");
Console.WriteLine($"Дата.месяц.год время(чч:мм) : {now:g}");
Console.WriteLine($"Текущий месяц и дата : {now:M}");
Console.WriteLine($"Текущий месяц и год : {now:Y}");
Console.WriteLine("Время(чч:мм:cc) : {0:T}", now);
Console.WriteLine(string.Format("Время(чч:мм) : {0:t}", now));

Console.WriteLine("*****");

DateOnly date = DateOnly.FromDateTime(now);
Console.WriteLine($"Дата месяц(прописью) год : {date:D}");
Console.WriteLine($"Дата.месяц.год : {date:d}");
//Console.WriteLine($"Дата месяц(прописью) год время(чч:мм:сс) : {date:F}");
//Console.WriteLine($"Дата месяц(прописью) год время(чч:мм) : {date:f}");

Console.WriteLine(date.ToLongDateString());
Console.WriteLine(date.ToShortDateString());

Console.WriteLine("*****");

TimeOnly time = TimeOnly.FromDateTime(now);

//Console.WriteLine($"Дата.месяц.год время(чч:мм) : {date:g}");
//Console.WriteLine($"Текущий месяц и дата : {date:M}");
//Console.WriteLine($"Текущий месяц и год : {date:Y}");
//Console.WriteLine($"Время(чч:мм:cc) : {date:T}");
//Console.WriteLine($"Время(чч:мм) : {date:t}");

Console.WriteLine(time.ToLongTimeString());
Console.WriteLine(time.ToShortTimeString());
// Delay.
Console.ReadKey();