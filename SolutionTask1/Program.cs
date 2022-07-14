// Задача 1 Напишите программу, которая на вход принимает два числа и проверяет, являетс ли первое число квадратом второго.

string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo != null)
{
    int inputNumberOne = int.Parse(inputLkneOne);
    int inputNumberTwo = int.Parse(inputLkneTwo);

    // if(inputNumberOne == inputNumberTwo * inputNumberTwo)
    // {
    //     Console.WriteLine("YES");
    // }
    // else{
    //     Console.WriteLine("NO");
    // }

    if(inputNumberTwo == Math.Sqrt(inputNumberOne))
    {
        Console.WriteLine("YES");
    }
    else{
        Console.WriteLine("NO");
    }
}