using Shared;
var response = string.Empty;
do
{
    try
    {
        var n = ConsoleExtension.GetInt("Ingrese número: ");
        var factorial = MyMath.Factorial(n);
        Console.WriteLine($"{n}! = {factorial:N0}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");
Console.WriteLine("\n:::::::::: GAME OVER ::::::::::\n");
