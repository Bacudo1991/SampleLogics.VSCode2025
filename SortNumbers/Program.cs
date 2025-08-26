using Shared;

var response = string.Empty;
do
{
    try
    {
        Console.WriteLine("Ingrese 3 números diferentes para ordenarlos de mayor a menor.");
        var a = ConsoleExtension.GetInt("Ingrese el primer número : ");
        var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");
        var c = ConsoleExtension.GetInt("Ingrese el tercer número : ");

        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Los números deben ser diferentes. Intente nuevamente.\n");
            continue;
        }

        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine($"El número mayor es {a}, el medio es {b} y el menor es {c}");
            }
            else
            {
                Console.WriteLine($"El número mayor es {a}, el medio es {c} y el menor es {b}");
            }
        }
        else if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine($"El número mayor es {b}, el medio es {a} y el menor es {c}");
            }
            else
            {
                Console.WriteLine($"El número mayor es {b}, el medio es {c} y el menor es {a}");
            }
        }
        else
        {
            if (a > b)
            {
                Console.WriteLine($"El número mayor es {c}, el medio es {a} y el menor es {b}");
            }
            else
            {
                Console.WriteLine($"El número mayor es {c}, el medio es {b} y el menor es {a}");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");
Console.WriteLine("\n:::::::::: GAME OVER ::::::::::");

