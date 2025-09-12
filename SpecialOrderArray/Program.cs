using System.Globalization;
using System.Runtime.InteropServices;
using Shared;
var response = string.Empty;
do
{
    try
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("::::::::: ORDENACIÓN ESPECIAL DE UN ARREGLO :::::::::");
        var n = ConsoleExtension.GetInt("¿Cuantas posiciones quieres en el arreglo?: ");
        var numbers = new int[n];

        FillArray(numbers);

        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("Arreglo sin ordenar => ");
        ShowArray(numbers);
        Console.WriteLine();

        var numbersEven = GetNumbersEven(numbers);
        var numbersOdd = GetNumbersOdd(numbers);
        OrderArray(numbersEven, true);
        OrderArray(numbersOdd);

        Console.WriteLine("Arreglo ordenado  => ");
        ShowArray(numbersEven);
        ShowArray(numbersOdd);
        Console.WriteLine();

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

int[] GetNumbersOdd(int[] numbers)
{
    var countOdds = 0;
    foreach (var number in numbers)
    {
        if (!IsEven(number))
        {
            countOdds++;
        }
    }

    var numbersOdd = new int[countOdds];
    var i = 0;
    foreach (var number in numbers)
    {
        if (!IsEven(number))
        {
            numbersOdd[i] = number;
            i++;
        }
    }
    return numbersOdd;
}

int[] GetNumbersEven(int[] numbers)
{
    var countEvens = 0;
    foreach (var number in numbers)
    {
        if (IsEven(number))
        {
            countEvens++;
        }
    }

    var numbersEven = new int[countEvens];
    var i = 0;
    foreach (var number in numbers)
    {
        if (IsEven(number))
        {
            numbersEven[i] = number;
            i++;
        }
    }
    return numbersEven;    
}

bool IsEven(int number) => number % 2 == 0;


void OrderArray(int[] numbers, bool isDecending = false)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (isDecending)
            {
                if (numbers[i] < numbers[j])
                {
                    Change(ref numbers[i], ref numbers[j]);
                }
            }
            else
            {
                if (numbers[i] > numbers[j])
                {
                    Change(ref numbers[i], ref numbers[j]);
                }
            }
        }
    }
}

void Change(ref int number1, ref int number2)
{
    int aux = number1;
    number1 = number2;
    number2 = aux;  
}

void ShowArray(int[] numbers)
{
    foreach (var number in numbers)
    {
        Console.Write($"{number,10:N0}");
    }
}

void FillArray(int[] numbers)
{
    var random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 100);
    }
}   