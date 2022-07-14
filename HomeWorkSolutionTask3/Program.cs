//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

string? inputLkwLine = Console.ReadLine();

if(inputLkwLine != null)
{
    int inputLine = int.Parse(inputLkwLine);
    
    if(inputLine%2 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}