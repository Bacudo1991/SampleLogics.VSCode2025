using Shared;

var response = string.Empty;
do
{
    try
    {
        Console.Write("Ingrese 3 números enteros para determinar cual es el mayor.\n");
        var number1 = ConsoleExtension.GetInt("Ingrese el primer número entero: ");
        var number2 = ConsoleExtension.GetInt("Ingrese el segundo número entero: ");
        var number3 = ConsoleExtension.GetInt("Ingrese el tercer número entero: ");

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"El número mayor es: {number1}\n");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"El número mayor es: {number2}\n");
        }
        else if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine($"El número mayor es: {number3}\n");
        }
        else if (number1 == number2 && number2 == number3)
        {
            Console.WriteLine("Los tres números son iguales.\n");
        }
        else if (number1 == number2 || number2 == number3 || number1 == number3)
        {
            Console.WriteLine("Hay al menos dos números iguales, no se puede determinar un unico mayor.\n");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper(); 
} while (response == "S");
