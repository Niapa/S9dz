/*
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
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/



/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
