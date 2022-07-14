// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

string? inputLine = Console.ReadLine();

if(inputLine != null)
{   
    int inputNumber = int.Parse(inputLine);
        // for(int x = 2; x <= inputNumber; x++)
        // if(x % 2 == 0)

    int startNumber = 2;

    string lineOutput = "";

    while (startNumber <= inputNumber)
    {
        lineOutput = lineOutput + startNumber+", ";
        startNumber = startNumber + 2;
    }
    
    Console.WriteLine(lineOutput);
  
    // Console.Write($"{x}, ");
}