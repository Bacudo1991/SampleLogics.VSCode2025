using System.Runtime.InteropServices;
using Shared;
var response = string.Empty;
do
{
    try
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("::::::::: ARREGLO PARES E IMPARES :::::::::");
        var n = ConsoleExtension.GetInt("¿Cuantas posiciones quieres en el arreglo?: ");
        var numbers = new int[n];

        FillArray(numbers);
        var sum = GetSumEven(numbers);
        var prod = GetProdOdd(numbers);

        ShowArray(numbers);
        Console.WriteLine($"La sumatoria es  : {sum,30:N0}");        
        Console.WriteLine($"La productoria es: {prod,30:N0}");        


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

double GetProdOdd(int[] numbers)
{
    double prod = 1;
    foreach (var number in numbers)
    {
        if (number % 2 != 0)
        {
            prod *= number;
        }
    }
    return prod;
}   


int GetSumEven(int[] numbers)
{
    var sum = 0;
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            sum += number;
        }
    }
    return sum;
}

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



