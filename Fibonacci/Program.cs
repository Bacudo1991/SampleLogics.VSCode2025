using Shared;
var response = string.Empty;
do
{
    try
    {
        var n = ConsoleExtension.GetInt("Cuántos términos quiere: ");
        double a = 0;
        double b = 1;

        Console.Write($"{a:N0}\t{b:N0}\t");

        for (int i = 2; i < n; i++)
        {
            double c = a + b;
            Console.Write($"{c:N0}\t");
            a = b;
            b = c;
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