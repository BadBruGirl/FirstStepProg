﻿//Задача 12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления .


//Решение Николая
// string? inputLkneOne = Console.ReadLine();
// string? inputLkneTwo = Console.ReadLine();

// if(inputLkneOne != null && inputLkneTwo != null){
//     int inputNumberOne = int.Parse(inputLkneOne);
//     int inputNumberTwo = int.Parse(inputLkneTwo);

//     int div = inputNumberTwo%inputNumberOne;

//     if(div == 0){
//         Console.WriteLine("yes");
//     }else{
//         Console.WriteLine(div);
//     }

// }

// //Решение Артема
// Console.Write("Enter first number: ");
// string? firstLine = Console.ReadLine();
// Console.Write("Enter second number: ");
// string? secondLine = Console.ReadLine();
// int first = int.Parse(firstLine);
// int second = int.Parse(secondLine);

// if (second%first == 0)
// {
//     Console.WriteLine("Кратное");
// }
// else
// {
//     Console.WriteLine("Не кратное, " + second%first);
// }

// //Решение Кирилла
// Console.WriteLine("Input two numbers: ");

// string? inputOne = Console.ReadLine();
// string? inputTwo = Console.ReadLine();

// string reminderSearcher(string str1, string str2)
// {
//     if (inputOne != null && inputTwo != null)
//     {
//         try {
//             string answer;
//             int num1 = int.Parse(str1);
//             int num2 = int.Parse(str2);
//             int remainder = num1 % num2;
//             if (remainder != 0){
//                 answer = "The remainder is : " + remainder;
//             } else {
//                 answer = "It's multiple!!!";
//             }
//             return answer;
//         }
//         catch(Exception e)
//         {
//             return "Возникло исключение: " + e.Message;
//         }
//     }
//     return "";
// }

// Console.WriteLine(reminderSearcher(inputOne,inputTwo));

//Решение Ирины

Console.WriteLine("введите первое число:");
string? firstNumber = Console.ReadLine();
Console.WriteLine("введите второе число:");
string? secondNumber = Console.ReadLine();

if (firstNumber != null && secondNumber != null) {
    int firstOutNumber = int.Parse(firstNumber);
    int secondOutNumber = int.Parse(secondNumber);
    int c = secondOutNumber % firstOutNumber;
    string iext = "";
    
    if (c == 0) {
        iext = "да, второе число кратно первому"; 
        Console.WriteLine(iext);
    } else {
        iext = "нет, второе число не кратно первому, остаток: " + c; 
        Console.WriteLine(iext);
    }
}

