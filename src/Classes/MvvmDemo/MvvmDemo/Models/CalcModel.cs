using System.Globalization;

namespace MvvmDemo.Models;

internal class CalcModel
{
    public string? Operand1 { private get; set; }
    public string? Operand2 { private get; set; }

    public string Sum
    {
        get
        {
            if (!double.TryParse(Operand1, out var operand1))
                return "Введите числа!";
            if (!double.TryParse(Operand2, out var operand2))
                return "Введите числа!";

            return (operand1 + operand2).ToString(CultureInfo.CurrentCulture);
        }
    }
}