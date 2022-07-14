//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int startNumber = 1;

    string lineOutput =  "0";

    while (startNumber <= inputNumber)
    {
        lineOutput = startNumber*(-1)+", "+lineOutput+", "+startNumber;
        startNumber++;
    }
    
    // lineOutput = lineOutput+inputNumber;

    Console.WriteLine(lineOutput);
}