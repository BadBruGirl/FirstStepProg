//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int findNumber = (inputNumber % 100)/10;

    Console.WriteLine(findNumber);
}    