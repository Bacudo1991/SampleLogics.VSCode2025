using System.Runtime.InteropServices;
using Shared;
var response = string.Empty;
do
{
    try
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("::::::::: OPERACIONES EN UN ARREGLO :::::::::");
        var n = ConsoleExtension.GetInt("¿Cuantas posiciones quieres en el arreglo?: ");
        var numbers = new int[n];

        FillArray(numbers);

        ShowArray(numbers);
        Console.WriteLine($"La sumatoria es: {numbers.Sum(),30:N2}");        
        Console.WriteLine($"El promedio es : {numbers.Average(),30:N2}");        
        


        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;



        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

Console.WriteLine("\n :::::::::: GAME OVER :::::::::: \n");

void ShowArray(int[] numbers)
{
    foreach (var number in numbers)
    {
        Console.Write($"{number,10:N0}");
    }
    Console.WriteLine();
}

void FillArray(int[] numbers)
{
    var random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 100);
    }
}
