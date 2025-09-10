using System.IO.Pipes;
using Shared;
var response = string.Empty;
do
{
    try
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("::::::::: CALENDARIO :::::::::");
        var year = ConsoleExtension.GetInt("Ingrese el año: ");

        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        ShowCalendar(year);

        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

Console.WriteLine("\n :::::::::: GAME OVER :::::::::: \n");

void ShowCalendar(int year)
{
    Console.WriteLine($"::::::::::::::::::::: AÑO {year} ::::::::::::::::::::");
    Console.WriteLine();
    List<string> months = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];
    int i = 1;
    foreach (var month in months)
    {

        Console.WriteLine($"{month}");
        Console.WriteLine("Dom\tLun\tMar\tMie\tJue\tVie\tSab");
        var daysPerMonth = GetDaysPerMonth(year, i);
        var zeller = Zeller(year, i);
        var daysCounter = 0;
        for (int j = 0; j < zeller; j++)
        {
            Console.Write("\t");
            daysCounter++;
        }
        for (int day = 1; day <= daysPerMonth; day++)
        {
            Console.Write($"{day}\t");
            daysCounter++;
            if (daysCounter == 7)
            {
                daysCounter = 0;
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        i++;
    }
}

int GetDaysPerMonth(int year, int month)
{
    if (month == 2 && DateUtilities.IsLeapYear(year))
    {
        return 29;
    }
    List<int> daysPerMonth = [0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
    return daysPerMonth.ElementAt(month);
}
//Devuelve 
//0 = Domingo, 1 = Lunes, 2 = Martes, 3 = Miercoles
//4 = Jueves, 5 = Viernes, 6 = Sábado
int Zeller(int ano, int mes)
{
    int a = (14 - mes) / 12;
    int y = ano - a;
    int m = mes + 12 * a - 2;
    int dia = 1, d;
    d = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
    return (d);
}



