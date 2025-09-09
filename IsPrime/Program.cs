using Shared;
var response = string.Empty;
do
{
    try
    {
        var n = ConsoleExtension.GetInt("Ingrese número: ");
        var isPrime = MyMath.IsPrime(n);
        Console.WriteLine($"El número: {n}, {(isPrime ? "si" : "no")} es primo");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

Console.WriteLine("\n :::::::::: GAME OVER :::::::::: \n");




