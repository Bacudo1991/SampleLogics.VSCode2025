using Shared;

var response = string.Empty;
do
{
    try
    {
        Console.Write("Ingrese 2 números enteros para saber si son multiplos entre sí\n");
        var number1 = ConsoleExtension.GetInt("Ingrese el primer número entero: ");
        var number2 = ConsoleExtension.GetInt("Ingrese el segundo número entero: ");

        if (number2 % number1 == 0)
        {
            Console.WriteLine($"{number1} es múltiplo de {number2}.\n");
        }
        else
        { 
            Console.WriteLine($"{number1} no es múltiplo de {number2}.\n");
        }     
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S"); 
