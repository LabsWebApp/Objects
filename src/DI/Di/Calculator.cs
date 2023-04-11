namespace Di;

//уместно, чтобы класс Calculator отвечал за запись в текстовый файл?
public class Calculator
{
    private readonly ILogger _logger;

    public Calculator(ILogger logger) => _logger = logger;

    public float Divide(float number1, float number2)
    {
        _logger.WriteLine($"Running {number1} / {number2}");
        return number1 / number2;
    }

    public float Multiply(float number1, float number2)
    {
        _logger.WriteLine($"Running {number1} * {number2}");
        return number1 * number2;
    }

    public float Add(float number1, float number2)
    {
        _logger.WriteLine($"Running {number1} + {number2}");
        return number1 + number2;
    }

    public float Subtract(float number1, float number2)
    {
        _logger.WriteLine($"Running {number1} - {number2}");
        return number1 - number2;
    }
}