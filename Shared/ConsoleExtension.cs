namespace Shared;

public class ConsoleExtension
{
    public static int GetInt(string message)
    {
        Console.Write(message);
        var input = Console.ReadLine();
        if (int.TryParse(input, out int numberInt))
        {
            return numberInt;
        }
        throw new Exception("El valor ingresado no es un número entero válido.");
    }
    
        public static float GetFloat(string message)
    {
        Console.Write(message);
        var numberString = Console.ReadLine();
        if (float.TryParse(numberString, out float numberFloat))
        {
            return numberFloat; 
        }
        throw new Exception("El valor ingresado no es válido.");
    }

        public static decimal GetDecimal(string message)
    {
        Console.Write(message);
        var numberString = Console.ReadLine();
        if (decimal.TryParse(numberString, out decimal numberDecimal))
        {
            return numberDecimal;  
        }
        throw new Exception("El valor ingresado no es válido.");
    }

    public static String? GetString(string message)
    {
        Console.Write(message);
        var text = Console.ReadLine();
        return text; ;

        throw new Exception("El valor ingresado no es válido.");
    }
}