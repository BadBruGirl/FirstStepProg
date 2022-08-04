// // Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// int inputNumberA;
// int inputNumberB;


// void Read()
// {
//     Console.WriteLine("Введите первое число:");
//     string inputA = Console.ReadLine();
//     inputNumberA = int.Parse(inputA ?? "");

//     Console.WriteLine("Введите второе число:");
//     string inputB = Console.ReadLine();
//     inputNumberB = int.Parse(inputB ?? "");
// }


// int Conculate1(int inputNumberA, int inputNumberB)
// {
//     int result = 1;
//     result = (int)Math.Pow(inputNumberA, inputNumberB);
//     return result;
// }

// int Conculate2(int inputNumberA, int inputNumberB)
// {
//     int i = 0;
//     int result = 1;
//     while (i < inputNumberB)
//     {
//         result = result * inputNumberA;
//         i++;
//     }
//     return result;
// }
// void Print()
// {
//     Console.WriteLine(Conculate1(inputNumberA, inputNumberB));
//     Console.WriteLine(Conculate2(inputNumberA, inputNumberB));
// }

// Read();
// Conculate1(inputNumberA, inputNumberB);
// Conculate2(inputNumberA, inputNumberB);
// Print();



double a;
double b;
double res = 0;
char oper;

Console.Write("Введите первое число:");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите действие:");
oper = Convert.ToChar(Console.ReadLine());

Console.Write("Введите второе число:");
b = Convert.ToDouble(Console.ReadLine());

if (oper == '+')
{
    res = a + b;
}

else
    if (oper == '-')
    {
    res = a - b;
    }

else 
    if (oper == '*')
{
    res = a * b;
}

else if (oper == '/')
{
    if (b != 0)
        res = a / b;
    else Console.WriteLine("На 0 делить нельзя!");
}
else if (oper == '^')
{
   res = Math.Pow(a,b);
    }
else
{
    Console.WriteLine("Неизвестный оператор.");
}

Console.WriteLine("Результат: {0}", res);
Console.ReadLine();
