// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void printAnswer(int number) //метод который распечатывает результат
{
    if(number==1) Console.WriteLine("Допустимо: x>0, y>0");
    if(number==2) Console.WriteLine("Допустимо: x<0, y>0");
    if(number==3) Console.WriteLine("Допустимо: x<0, y<0");
    if(number==4) Console.WriteLine("Допустимо: x>0, y<0");
}

string? inputLine = Console.ReadLine(); //отсюда начинается программа - считывает строчку с консоли

if(inputLine != null) // проверит что б строка была не пустая
{
    int inputNumber = int.Parse(inputLine); //превратили в вещественное число

    printAnswer(inputNumber); //использует метод 

}