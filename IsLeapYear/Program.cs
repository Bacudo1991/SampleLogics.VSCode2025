using Shared;

var response = string.Empty;
do
{
    try
    {
        Console.Write("Ingrese un año para saber si es bisiesto o no.\n");
        var currentYear = DateTime.Now.Year;
        var message = string.Empty;
        var year = ConsoleExtension.GetInt("Ingrese el año a consultar: ");

        if (year == currentYear)
        {
            message = "es";
        }
        else if (year > currentYear)
        { 
            message = "va a ser";
        }
        else
        {
            message = "fue";
        }

        if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine($"El año: {year} {message} bisiesto.");
                    }
                    else
                    {
                        Console.WriteLine($"El año: {year} no {message} bisiesto.");
                    }
                }
                else
                {
                    Console.WriteLine($"El año: {year} {message} bisiesto.");
                }
            }
            else
            {
                Console.WriteLine($"El año: {year} no {message} bisiesto.");
            }        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper(); 
} while (response == "S");
