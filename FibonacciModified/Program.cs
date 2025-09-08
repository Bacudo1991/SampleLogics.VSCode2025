using Shared;
var response = string.Empty;
do
{
    try
    {
        var n = ConsoleExtension.GetInt("Cuántos términos quiere: ");
        double a = 0;
        double b = 1;
        double c = 2;

        Console.Write($"{a,20:N0}{b,20:N0}{c,20:N0}");

        for (int i = 3; i < n; i++)
        {
            double d = a + b + c;
            Console.Write($"{d,20:N0}");
            a = b;
            b = c;
            c = d;
        }
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

Console.WriteLine("\n :::::::::: GAME OVER :::::::::: \n");