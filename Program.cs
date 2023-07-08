﻿/*
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

double StepenNumber(int start, int end)
{
    if (end == 0) return 1;
    if (end > 0)
        return start * StepenNumber(start, end - 1);
    else
        return Math.Round(1 / (start * StepenNumber(start, -end - 1)), 3);
}

int numA = InputNum("Введите целое число A: ");
int numB = InputNum("Введите целое число B: ");
Console.WriteLine(StepenNumber(numA, numB));

Задача 64: 
___________
Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


_______________________________________________________________________

*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string PrintNumbers(int value)
{
    if (value < 1) return ("Введенное число меньше 1.");
        if (value == 1) return ("1");
            else return (value + " " + PrintNumbers(value - 1));
}


int num = InputNum("Введите целое число N, N > 1: ");
Console.WriteLine(PrintNumbers(num));

/*
Задача 66: 
___________
Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
_______________________________________________________________



int InputNum (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string SumNumbers(int start, int end)
{
    int sum = 0;
    if (temp == end) return end.ToString();
    if (temp > end) return (start + SumNumbers(start + 1, end));
}

 
int num1 = InputNum("Введите целое число М: ");
int num2 = InputNum("Введите целое число N: ");
Console.WriteLine (PrintNumbers(num1, num2)); 
*/

/*
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

double StepenNumber(int start, int end)
{
    if (end == 0) return 1;
    if (end > 0)
        return start * StepenNumber(start, end - 1);
    else
        return Math.Round(1 / (start * StepenNumber(start, -end - 1)), 3);
}

int numA = InputNum("Введите целое число A: ");
int numB = InputNum("Введите целое число B: ");
Console.WriteLine(StepenNumber(numA, numB));

Задача 64: 
___________
Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


_______________________________________________________________________



int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string PrintNumbers(int value)
{
    if (value < 1) return ("Введенное число меньше 1.");
        if (value == 1) return ("1");
            else return (value + " " + PrintNumbers(value - 1));
}


int num = InputNum("Введите целое число N, N > 1: ");
Console.WriteLine(PrintNumbers(num));


Задача 66: 
___________
Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
_______________________________________________________________

*/

int InputNum (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int SumNumbers(int start, int end)
{
    if (start == end) return (start + end);
        if (start > end) return (start + SumNumbers(start - 1, end));
            else return (SumNumbers(++start));
}

 
int num1 = InputNum("Введите целое число М: ");
int num2 = InputNum("Введите целое число N: ");
Console.WriteLine (SumNumbers(num1, num2)); 
