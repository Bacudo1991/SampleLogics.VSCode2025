using Shared;

var response = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    try
    {
        var routeOptions = new List<string> { "1", "2", "3", "4" };
        var route = string.Empty;
        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::");
        Console.WriteLine("::::::::::::::::: DATOS DE ENTRADA ::::::::::::::");
        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::\n");
        do
        {
            route = ConsoleExtension.GetValidOptions("Ruta [1][2][3][4] ..............................: ", routeOptions);
        } while (!routeOptions.Any(x => x == route));

        var trips = ConsoleExtension.GetInt("Número de viajes................................: ");
        var passangers = ConsoleExtension.GetInt("Número de pasajeros total.......................: ");
        var packages10 = ConsoleExtension.GetInt("Número de encomiendas de menos de 10kg .........: ");
        var packages10_20 = ConsoleExtension.GetInt("Número de encomiendas entre 10kg y menos de 20kg: ");
        var packages20 = ConsoleExtension.GetInt("Número de encomiendas de mas de 20kg ...........: ");

        //CALCULATIONS

        var incomePassangers = GetIncomePassangers(route, passangers, trips);
        var incomePackages = GetIncomePackages(route, packages10, packages10_20, packages20);
        var incomes = incomePassangers + incomePackages;
        var valueHelper = GetValueHelper(incomes);
        var valueAssurance = GetValueAssurance(incomes);
        var fuelValue = GetFuelValue(route, passangers, packages10, packages10_20, packages20, trips);
        var deductions = valueHelper + valueAssurance + fuelValue;
        var totalToPay = incomes - deductions;
        Console.WriteLine("\n:::::::::::::::::::::::::::::::::::::::::::::::::");
        Console.WriteLine(":::::::::::::::::::: CÁLCULOS :::::::::::::::::::");
        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::\n");
        Console.WriteLine($"Ingresos por pasajeros..........................: {incomePassangers,20:C2}");
        Console.WriteLine($"Ingresos por encomiendas........................: {incomePackages,20:C2}");
        Console.WriteLine($"                                                  --------------------");
        Console.WriteLine($"TOTAL INGRESOS .................................: {incomes,20:C2}");
        Console.WriteLine($"Pago ayudante ..................................: {valueHelper,20:C2}");
        Console.WriteLine($"Pago seguro ....................................: {valueAssurance,20:C2}");
        Console.WriteLine($"Pago combustible ...............................: {fuelValue,20:C2}");
        Console.WriteLine($"                                                  --------------------");
        Console.WriteLine($"TOTAL DEDUCCIONES ..............................: {deductions,20:C2}");
        Console.WriteLine($"                                                  ====================");
        Console.WriteLine($"TOTAL A LIQUIDAR ...............................: {totalToPay,20:C2}");
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.Write("¿Desea continuar? (S/N).........................: ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

decimal GetFuelValue(string? route, int passangers, int packages10, int packages10_20, int packages20, int trips)
{
    float kms;
    switch (route)
    {
        case "1":
            kms = 150 * trips;
            break;
        case "2":
            kms = 167 * trips;
            break;
        case "3":
            kms = 184 * trips;
            break;
        default:
            kms = 203 * trips;
            break;
    }
    var gallons = kms / 39;
    var value = (decimal)gallons * 8860;
    var weight = passangers * 60 + packages10 * 10 + packages10_20 * 15 + packages20 * 20;
    if (weight < 5000) return value;
    if (weight <= 10000) return value * 1.1m;
    return value * 1.25m;
}

decimal GetValueAssurance(decimal incomes)
{
    if (incomes < 1000000) return incomes * 0.03m;
    if (incomes < 2000000) return incomes * 0.04m;
    if (incomes < 4000000) return incomes * 0.06m;
    return incomes * 0.09m;
}

decimal GetValueHelper(decimal incomes)
{
    if (incomes < 1000000) return incomes * 0.05m;
    if (incomes < 2000000) return incomes * 0.08m;
    if (incomes < 4000000) return incomes * 0.1m;
    return incomes * 0.13m;
}

decimal GetIncomePackages(string? route, int packages10, int packages10_20, int packages20)
{
    decimal value = 0;
    switch (route)
    {
        case "1":
        case "2":
            if (packages10 < 50) value += packages10 * 100;
            else if (packages10 <= 100) value += packages10 * 120;
            else if (packages10 <= 130) value += packages10 * 150;
            else value += packages10 * 160;  

            var packagesGreather10 = packages10_20 + packages20;
            if (packagesGreather10 < 50) value += packagesGreather10 * 120;
            else if (packagesGreather10 <= 100) value += packagesGreather10 * 140;
            else if (packagesGreather10 <= 130) value += packagesGreather10 * 160;
            else value += packagesGreather10 * 180;        
            return value;
            
        default:
            if (packages10 < 50) value += packages10 * 130;
            else if (packages10 <= 100) value += packages10 * 160;
            else if (packages10 <= 130) value += packages10 * 175;
            else value += packages10 * 200;  

            if (packages10_20< 50) value += packages10_20 * 140;
            else if (packages10_20 <= 100) value += packages10_20 * 180;
            else if (packages10_20 <= 130) value += packages10_20 * 200;
            else value += packages10_20 * 250;

            if (packages20 < 50) value += packages20 * 170;
            else if (packages20 <= 100) value += packages20 * 210;
            else if (packages20 <= 130) value += packages20 * 250;
            else value += packages20 * 300;
            return value; 
    }
}

decimal GetIncomePassangers(string? route, int passangers, int trips)
{
    decimal value;
    switch (route)
    {
        case "1":
            value = 500000 * trips;
            if (passangers < 50) return value; 
            if (passangers <= 100) return value * 1.05m; 
            if (passangers <= 100) return value * 1.06m; 
            if (passangers <= 100) return value * 1.07m;
            return value * 1.07m + (passangers - 200) * 50m;            
        case "2":
            value = 600000 * trips;
            if (passangers < 50) return value; 
            if (passangers <= 100) return value * 1.07m; 
            if (passangers <= 100) return value * 1.08m; 
            if (passangers <= 100) return value * 1.09m;
            return value * 1.09m + (passangers - 200) * 60m;              
        case "3":
            value = 800000 * trips;
            if (passangers < 50) return value; 
            if (passangers <= 100) return value * 1.1m; 
            if (passangers <= 100) return value * 1.13m; 
            if (passangers <= 100) return value * 1.15m;
            return value * 1.15m + (passangers - 200) * 100m;  
        default:
            value = 1000000 * trips;
            if (passangers < 50) return value; 
            if (passangers <= 100) return value * 1.125m; 
            if (passangers <= 100) return value * 1.15m; 
            if (passangers <= 100) return value * 1.17m;
            return value * 1.17m + (passangers - 200) * 150m;            
    }
}