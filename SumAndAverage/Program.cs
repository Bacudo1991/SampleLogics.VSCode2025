using Shared;
var response = string.Empty;
do
{
    try
    {
        var n = ConsoleExtension.GetInt("Cuantos números desea: ");
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{i}\t");
            sum += i;
        }
        var average = sum / n;
        Console.WriteLine();
        Console.WriteLine($"La suma es: {sum,20:N0}");
        Console.WriteLine($"El promedio es: {average,20:N0}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");
Console.WriteLine("\n:::::::::: GAME OVER ::::::::::\n");
