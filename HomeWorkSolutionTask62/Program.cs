// Задача 62. Заполните спирально массив 4 на 4.

int[,] InputMatrix() // метод введения формата массива, в данной задаче он должен быть 4х4
{
    int n = 4;
    int[,] matrix = new int[n, n];
    return matrix;
}

int SpiralMatrix(int[,] squareMatrix) // метод переставления чисел в массиве по спирали
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
    {
        squareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return temp;
}

void WriteArray(int[,] array) // метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] squareMatrix = InputMatrix();
SpiralMatrix(squareMatrix);
WriteArray(squareMatrix);
