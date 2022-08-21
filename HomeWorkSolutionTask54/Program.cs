// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int [,] inputArray () // метод ввода размера массива
{   
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine()); // превратили в вещественное число
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
return array;
}

void OrderArrayLines(int[,] array) // метод упорядочивания
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void CreateArray(int[,] array) // метод генерации массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,100);
    }
  }
}

void WriteArray(int[,] array) // метод печати массива
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


int[,] array = inputArray ();
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);




