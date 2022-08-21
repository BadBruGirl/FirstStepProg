// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] inputArray() // метод ввода заданного массива
{
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine()); // превратили в вещественное число
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    return array;
}

void CreateArray(int[,] array) // метод генерации массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 30);
        }
    }
}

void WriteArray(int[,] array) //метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumLineElements(int[,] array, int i) // метод нахождения суммы элементов массива в методе определения строки
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int FindMinSumLine(int[,] array) // определение номера строки с наименьшей суммой элементов
{
    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) всех элементов ");
    return minSumLine;
}

int[,] array = inputArray();
CreateArray(array);
WriteArray(array);
FindMinSumLine(array);
