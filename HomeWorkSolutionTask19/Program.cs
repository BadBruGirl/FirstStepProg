//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string? inputLine = Console.ReadLine(); //открыли строку для ввода в консоль

if(inputLine != null)  //проверили на null
{
    int inputNumberP = int.Parse(inputLine); //превратили в вещественное число

    int digit1 = inputNumberP/10000; //нашли первую цифру числа
    int digit2 = (inputNumberP/1000)%10; //нашли вторую цифру числа
    int digit3 = (inputNumberP/100)%10; //нашли третью цифру числа
    int digit4 = (inputNumberP/10)%10; //нашли четвертую цифру числа
    int digit5 = inputNumberP%10; //нашли пятую цифру числа

    if (digit1 == digit5&&digit2==digit4) //сравнили 1и5 2и4 цифры числа
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}