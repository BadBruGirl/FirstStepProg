// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

int valueB1;
int valueK1;
int valueB2;
int valueK2;
int coordyX=0;
int coordyY=0;
string coordy;

ReadingFunctionValues();
Conculate();
PrintPointOfIntersectionOfCoordinates();


void ReadingFunctionValues()
{
    Console.WriteLine("Введите значение b1");
    valueB1 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение k1");
    valueK1 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение b2");
    valueB2 = int.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение k2");
    valueK2 = int.Parse(Console.ReadLine()?? "");
}

void Conculate()
{
    if ((valueK1 == valueK2)&&(valueB1 == valueB2))
    
        Console.WriteLine("Прямые совпадают");
    else
        if (valueK1 == valueK2)
        Console.WriteLine("Прямые совпадают");        
    else
        {
            coordyX=(valueB2-valueB1)/(valueK1-valueK2);
            coordyY=(valueK1*(valueB2-valueB1))/(valueK1-valueK2)+valueB1;
        }  
    coordy = "Координаты точки пересечения: " + coordyX + "," + coordyY;
}

void PrintPointOfIntersectionOfCoordinates()
{
    Console.WriteLine(coordy);
}    