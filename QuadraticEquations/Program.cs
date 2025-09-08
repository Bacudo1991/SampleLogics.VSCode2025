using Shared;
var response = string.Empty;
do
{
    try
    {
        var a = ConsoleExtension.GetDouble("Ingrese el valor de a: ");
        var b = ConsoleExtension.GetDouble("Ingrese el valor de b: ");
        var c = ConsoleExtension.GetDouble("Ingrese el valor de c: ");
        var solution = QuadraticEquation(a, b, c);

        Console.WriteLine($"x1 = {solution.X1:N5}");
        Console.WriteLine($"x2 = {solution.X2:N5}");



    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

Console.WriteLine("\n :::::::::: GAME OVER :::::::::: \n");


QuadraticEquationSolution QuadraticEquation(double a, double b, double c)
{
    return new QuadraticEquationSolution
    {
        X1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a),
        X2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a),
    };  
}

public class QuadraticEquationSolution
{
    public double X1 { get; set; }
    public double X2 { get; set; }
}
