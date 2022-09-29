/*
 * Ухватов Владислав 22-ИСП-2/1
 * 2.2. Условные операторы
 * Высокий уровень, 18 вариант (30 страница)
 */

string GetNotNullableVariable(string variableName)
{
    while (true)
    {
        Console.Write($"Enter {variableName} value: ");
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            return input;
        }

        Console.WriteLine("The entered value cannot be null.");
    }
}

double GetDoubleFromCommandLine(string variableName = "variable")
{
    while (true)
    {
        var stringNumber = GetNotNullableVariable(variableName);

        if (double.TryParse(stringNumber, out var parsed)) return parsed;

        Console.WriteLine("The entered number must be of type double.");
    }
}

bool Calculate(double fWidth, double fHeight, double sWidth, double sHeight)
{
    return (fWidth < sWidth && fHeight < sHeight) || (fWidth < sHeight && fHeight < sWidth);
}

var firstRectangleWidth = GetDoubleFromCommandLine("width of the first rectangle");
var firstRectangleHeight = GetDoubleFromCommandLine("height of the first rectangle");
var secondRectangleWidth = GetDoubleFromCommandLine("width of the second rectangle");
var secondRectangleHeight = GetDoubleFromCommandLine("height of the second rectangle");

var answer = Calculate(
    firstRectangleWidth,
    firstRectangleHeight,
    secondRectangleWidth,
    secondRectangleHeight
)
    ? "можно"
    : "нельзя";

Console.WriteLine($"Прямоугольник со сторонами [{firstRectangleWidth}, {firstRectangleHeight}] {answer}" +
                  $" поместить в прямоугольник со сторонами [{secondRectangleWidth}, {secondRectangleHeight}]");