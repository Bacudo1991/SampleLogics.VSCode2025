using Shared;
var response = string.Empty;
do
{
    try
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("::::::::: CÁLCULO DEL NÚMERO E :::::::::");
        var n = ConsoleExtension.GetInt("Cuantos términos de precisión desea: ");

        var e = CalculateE(n);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine($"El valor de 'e' con: {n} términos de precisión es: {e}");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

Console.WriteLine("\n :::::::::: GAME OVER :::::::::: \n");

double CalculateE(int n)
{
    double sum = 0;
    for (var i = 0; i < n; i++)
    {
        sum += 1 / MyMath.Factorial(i);

    }
    return sum;
}





