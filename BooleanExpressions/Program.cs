/*
 * Ухватов Владислав 22-ИСП-2/1
 * 2.1. Логические выражения
 * Высокий уровень, 18 вариант (23 страница)
 */

string GetNotNullableVariable(string variableName) {
    while (true) {
        Console.Write($"Enter {variableName} value: ");
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input)) {
            return input;
        }

        Console.WriteLine("The entered value cannot be null.");
    }
}

double GetDoubleFromCommandLine(string variableName = "variable") {
    while (true) {
        var stringNumber = GetNotNullableVariable(variableName);

        if (double.TryParse(stringNumber, out var parsed)) return parsed;
        
        Console.WriteLine("The entered number must be of type double.");
    }
}

bool Calculate(double xVariable, double yVariable)
{
    return (yVariable >= Math.Pow(xVariable, 2) - 2) && (yVariable <= xVariable);
}

var x = GetDoubleFromCommandLine("<x>");
var y = GetDoubleFromCommandLine("<y>");

var pretext = Calculate(x, y) ? "" : "не";
Console.WriteLine($"Точка ({x}, {y}) {pretext} входит в заданный диапозон.");
