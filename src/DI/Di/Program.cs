using Di;

var number1 = GetNumber("Enter the first number: > ");
var number2 = GetNumber("Enter the second number: > ");
var operation = GetOperator();

// Следующие две строки изменены
//var logger = new FileLogger();
var logger = new NullLogger();
var calc = new Calculator(logger);

var result = GetResult(calc, number1, number2, operation);
Console.WriteLine($"{number1} {operation} {number2} = {result}");
Console.Write("Press any key to continue...");
Console.ReadKey();

static float GetNumber(string message)
{
    var isValid = false;
    while (!isValid)
    {
        Console.Write(message);
        var input = Console.ReadLine();
        isValid = float.TryParse(input, out var number);
        if (isValid)
            return number;

        Console.WriteLine("Введите число. Или ^C для выхода.");
    }

    return -1;
}

static char GetOperator()
{
    while (true)
    {
        Console.Write("Выберите действие (/*+-) > ");
        var input = Console.ReadKey();
        Console.WriteLine();
        var operation = input.KeyChar;
        if ("/*+-".Contains(operation)) return operation;

        Console.WriteLine("Слишком сложный оператор (/, *, +, or -). " +
                          "Или ^C для выхода.");
    }
}

static float GetResult(Calculator calc, float number1, float number2, char operation) =>
    operation switch
    {
        '/' => calc.Divide(number1, number2),
        '*' => calc.Multiply(number1, number2),
        '+' => calc.Add(number1, number2),
        '-' => calc.Subtract(number1, number2),
        _ => throw new InvalidOperationException("Нет такой операции: " + operation)
    };