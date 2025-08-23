using Shared;

var response = string.Empty;
do
{
    try
    {
        var desks = ConsoleExtension.GetInt("Número de escritorios: ");
        var valueToPay = CalculateValue(desks);

        Console.WriteLine($"El valor a pagar es..: {valueToPay:C2}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper(); 
} while (response == "S");

decimal CalculateValue(int desks)
{
        float discount;
        if (desks < 5)
        {
            discount = 0.1f;
        }
        else if (desks < 10)
        {
            discount = 0.2f;
        }
        else
        {
            discount = 0.4f;
        }
        
        return desks * 650000 * (decimal)(1 - discount);
}