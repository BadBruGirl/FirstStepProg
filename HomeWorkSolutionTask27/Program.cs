// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);
int sum=0;

void Conculate(int inputNum)
{
while (inputNum>0)
{
    sum=sum+inputNum%10;
    inputNum=inputNum/10;
}
}

Conculate(inputNum);

Console.WriteLine(sum);