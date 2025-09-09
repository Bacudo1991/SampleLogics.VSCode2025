using Shared;
var response = string.Empty;
do
{
    try
    {
        var n = ConsoleExtension.GetInt("Cuantos números primos quieres: ");
        var primes = GetPrimes(n);
        foreach (var prime in primes)
        {
            Console.Write($"{prime,10:N0}");
        }
        Console.WriteLine();
        Console.WriteLine($"La sumatoria es: {primes.Sum(),10:N0}");
        Console.WriteLine($"El promedio es: {primes.Average(),10:N0}");
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

Console.WriteLine("\n :::::::::: GAME OVER :::::::::: \n");

List<int> GetPrimes(int n)
{
    var primes = new List<int>();
    var num = 2;
    while (primes.Count < n)
    {
        if (MyMath.IsPrime(num))
        {
            primes.Add(num);
        }
        num++;
    }
    return primes;
}




