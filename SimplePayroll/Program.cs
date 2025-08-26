using Shared;

var response = string.Empty;
do
{
    try
    {
        var name = ConsoleExtension.GetString("Ingrese el nombre del empleado....................: ");
        var workedHours = ConsoleExtension.GetFloat("Ingrese las horas trabajadas......................: ");
        var hourValue = ConsoleExtension.GetDecimal("Ingrese el valor por hora.........................: ");
        var salaryMinimum = ConsoleExtension.GetDecimal("Ingrese el salario mínimo mensual.................: ");

        var salary = (decimal)workedHours * hourValue;
        if (salary < salaryMinimum)
        {
            Console.WriteLine($"Nombre............................................: {name}");
            Console.WriteLine($"Salario...........................................: {salaryMinimum:C2}");
        }
        else
        {
            Console.WriteLine($"Nombre............................................: {name}");
            Console.WriteLine($"Salario...........................................: {salary:C2}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");
Console.WriteLine("\n:::::::::: GAME OVER ::::::::::\n");


