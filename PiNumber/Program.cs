using Shared;
var response = string.Empty;
do
{
    try
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("::::::::: CÁLCULO DEL NÚMERO PI :::::::::");
        var n = ConsoleExtension.GetInt("Cuantos términos de precisión desea: ");

        var pi = CalculatePi(n);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine($"El valor de 'pi' con: {n} términos de precisión es: {pi}");

        Console.BackgroundColor = ConsoleColor.Black;
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

double CalculatePi(int n)
{
    double sum = 0;
    double den = 1;
    int sig = 1;
    for (int i = 0; i < n; i++)
    {
        double ter = 1 / den * sig;
        sum += ter;
        den += 2;
        sig *= -1;        
    }
    return sum * 4;
}


