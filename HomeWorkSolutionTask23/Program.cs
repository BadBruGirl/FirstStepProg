//Задача 22 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNNN = string.Empty; //Пустая строка
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNNN = lineNNN + (s * s * s) + " ";
        s++;
    }

    Console.WriteLine(lineN);
    Console.WriteLine(lineNNN);
}
