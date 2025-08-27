using Shared;
var response = string.Empty;
do
{
    try
    {
        var n = ConsoleExtension.GetInt("Cuantos términos desea:");
        var x = ConsoleExtension.GetDouble("Digite el valor de x: ");
        var taylor = Taylor(x, n);
        Console.WriteLine($"f({x}) = {taylor:N5}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");
Console.WriteLine("\n:::::::::: GAME OVER ::::::::::\n");

double Taylor(double x, int n)
{
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += Math.Pow(x, i) / MyMath.Factorial(i);
    }
    return sum;
}

