Задача 64: 
___________
Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
_________________________________________________________________________________

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
_________________________________________________________________________________

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int SumNumbers(int start, int end)
{
    if (start == end) return (end);
        if (start > end) return (start + SumNumbers(--start, end));
            else return (start + SumNumbers(++start, end)); 
}

int num1 = InputNum("Введите целое число M: ");
int num2 = InputNum("Введите целое число N: ");
Console.WriteLine($"Сумма чисел от M до N равна: {SumNumbers(num1, num2)}");

Задача 68: 
__________
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
__________________________________________________________________________________
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

функция ack(m, n)
   если m = 0
     вернуть n + 1
   иначе, если n = 0
     вернуть ack (m - 1, 1)
   еще
     вернуть ack(m - 1, ack (m, n - 1))
*/

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int Akkerman(int start, int end)
{
    if (start == 0) return (end + 1);
        if (end == 0) return Akkerman(start - 1, 1);
            else return Akkerman(start - 1, Akkerman (start, end - 1)); 
}

int num1 = InputNum("Введите целое число M: ");
int num2 = InputNum("Введите целое число N: ");
Console.WriteLine($"Результат равен: {Akkerman(num1, num2)}");
﻿
﻿
