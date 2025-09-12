using System.Runtime.InteropServices;
using Shared;
var response = string.Empty;
do
{
    try
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("::::::::: FRASES PALINDROMAS :::::::::");
        var phrase = ConsoleExtension.GetString("Ingrese la palabra o frase: ");


        var isPalindrome = IsPaliandrome(phrase);


        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine($"La palabra o frase: '{phrase}' {(isPalindrome ? "Sí" : "No")} es palíndrome.");

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("¿Desea continuar? (S/N): ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");

Console.WriteLine("\n :::::::::: GAME OVER :::::::::: \n");


bool IsPaliandrome(string? phrase)
{
    phrase = PreparePhrase(phrase);
    var n = phrase!.Length;
    for (var i = 0; i < n / 2; i++)
    {
        if (phrase[i] != phrase[n - i - 1])
        {
            return false;
        }

    }
    return true;
}

string? PreparePhrase(string? phrase)
{
    phrase = phrase!.ToLower();
    var newPhrase = string.Empty;
    var exceptions = new List<char> { ' ', ',', '.', '!', '¡', '¿', '?', ':', ';' };

    foreach (var character in phrase)
    {
        if (!exceptions.Contains(character))
        {
            
            newPhrase += character;
        }
    }
    return newPhrase;
}