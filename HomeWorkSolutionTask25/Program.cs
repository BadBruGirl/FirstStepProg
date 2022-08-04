// Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int inputNumberA;
int inputNumberB;


void Read()
{
    Console.WriteLine("Введите первое число:");
    string inputA = Console.ReadLine();
    inputNumberA = int.Parse(inputA ?? "");

    Console.WriteLine("Введите второе число:");
    string inputB = Console.ReadLine();
    inputNumberB = int.Parse(inputB ?? "");
}


int Conculate1(int inputNumberA, int inputNumberB)
{
    int result = 1;
    result = (int)Math.Pow(inputNumberA, inputNumberB);
    return result;
}

int Conculate2(int inputNumberA, int inputNumberB)
{
    int i = 0;
    int result = 1;
    while (i < inputNumberB)
    {
        result = result * inputNumberA;
        i++;
    }
    return result;
}
void Print()
{
    Console.WriteLine(Conculate1(inputNumberA, inputNumberB));
    Console.WriteLine(Conculate2(inputNumberA, inputNumberB));
}

Read();
Conculate1(inputNumberA, inputNumberB);
Conculate2(inputNumberA, inputNumberB);
Print();
