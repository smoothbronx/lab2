/*
 * Ухватов Владислав 22-ИСП-2/1
 * 2.3. Оператор выбора вариантов
 * Средний уровень, 18 вариант (36 страница)
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

int GetIntegerFromCommandLine(string variableName = "variable")
{
    while (true)
    {
        var stringNumber = GetNotNullableVariable(variableName);

        if (int.TryParse(stringNumber, out var parsed)) return parsed;

        Console.WriteLine("The entered number must be of type int.");
    }
}

double Calculate(double xVariable, double a, double b, double z)
{
    if (xVariable < -Math.Log(Math.Abs(a)))
    {
        return Math.Pow(3.5 * a - 7.3 * b * xVariable + Math.Sin(z * xVariable), 3);
    }

    if (-Math.Log(Math.Abs(a)) <= xVariable && xVariable < b)
    {
        return Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * xVariable), 3);
    }

    return Math.Sqrt(Math.Abs(Math.Tan(a) - xVariable) - Math.Pow(xVariable, 2));
}

void Main()
{
    double a, b;

    var x = GetDoubleFromCommandLine("<x>");
    var selectedVariant = GetIntegerFromCommandLine("variant");

    switch (selectedVariant)
    {
        case 1:
        {
            a = 6;
            b = 3.2;
            break;
        }
        case 2:
        {
            a = 3;
            b = 6;
            break;
        }
        case 3:
        {
            a = 2.7;
            b = 1.8;
            break;
        }
        default:
            throw new Exception("This variant number does not exist.");
    }
    var z = Math.Pow(Math.E, 1.5 * a * x);

    var y = Calculate(x, a, b, z);
    Console.WriteLine($"y = {y}");
}

Main();
