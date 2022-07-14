//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo != null)
{
    int inputNumberOne = int.Parse(inputLkneOne);
    int inputNumberTwo = int.Parse(inputLkneTwo);

    if(inputNumberOne > inputNumberTwo)
    {
        Console.WriteLine($"max = {inputNumberOne}");
    }
    else{
        Console.WriteLine($"max = {inputNumberTwo}");
    }
}