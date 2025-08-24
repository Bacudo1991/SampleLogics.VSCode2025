using Shared;

var response = string.Empty;
do
{
    try
    {
        var credits = ConsoleExtension.GetInt("Ingrese la cantidad de créditos...............: ");
        var creditValue = ConsoleExtension.GetDecimal("Ingrese el valor del crédito..................: ");
        var stratum = ConsoleExtension.GetInt("Ingrese el estrato del estudiante.............: ");

        var registrationValue = CalculateRegistrationValue(credits, creditValue, stratum);
        var subsidy = CalculateSubsidy(stratum);

        Console.WriteLine($"El valor de la matrícula es...................: {registrationValue,20:C2}");
        Console.WriteLine($"El valor del subsidio es......................: {subsidy,20:C2}");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N).......................: ");
    response = Console.ReadLine()!.ToUpper(); 
} while (response == "S");

decimal CalculateSubsidy(int stratum)
{
    if (stratum == 1)
    {
        return 200000;
    }
    if (stratum == 2)
    {
        return 100000;
    }
    return 0;
}

decimal CalculateRegistrationValue(int credits, decimal creditValue, int stratum)
{
    decimal value;
    if (credits <= 20)
    {
        value = credits * creditValue;
    }
    else
    {
        value = 20 * creditValue;
        value += (credits - 20) * creditValue * 2;
    }
    if (stratum == 1)
    {
        return value * 0.2m;
    }
    if (stratum == 2)
    {
        return value * 0.5m;
    }
    if (stratum == 3)
    {
        return value * 0.7m;
    }
    return value;
}