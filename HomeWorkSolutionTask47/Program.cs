// Задача №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow
                                        };

double[,] ArrayParameters() //метод введения размера массива
{
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine()); // превратили в вещественное число
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Clear(); //очистили консоль
    Console.WriteLine($"m = {m}, n = {n}.");
    double[,] array = new double[m, n]; // положили переменные в массив
    return array; //вернули массив

}

void CreateArrayDouble(double[,] newArray) // метод заполнения двумерного массива рандомными числами
{
    for (int i = 0; i < newArray.GetLength(0); i++) 
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().NextDouble() * 20 ; // превращение чисел в вещественные
        }
    }
}

void PrintColorArray(double[,] newArray) //метод печати массива в цветном варианте
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            
            Console.ForegroundColor = col[new System.Random().Next(0,16)]; 
            Console.Write(newArray[i, j] + " ");
            
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

double[,] newArray = ArrayParameters();
CreateArrayDouble(newArray);
PrintColorArray(newArray);


