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



)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
S9
Задача 63: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int InputNum (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }


// void PrintNumbers(int start, int end)
// {
//     if (start > end) return;
//     Console.Write(start + " ");
//     PrintNumbers(++start, end);
// }

// int num = InputNum("Введите целое число: ");
// PrintNumbers(1, num);

// int end = 5;
// int start = 1;
// end = end + start++;
// System.Console.WriteLine(end);
// System.Console.WriteLine(start);


string PrintNumbers(int start, int end)
{
    if (end == 1) return String.Empty;
    else return (PrintNumbers(start, --end) + " " + end);
}


Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
Задача 67: Напишите программу, которая будет принимать на вход 
число и возвращать сумму его цифр.
453 -> 12
45 -> 9

65

int InputNum (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
 }


67


int InputNum (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

int start = InputNum("Введите целое число М: ");
int num = InputNum("Введите целое число N: ");
System.Console.WriteLine(PrintNumbers(start, 




string PrintNumbers(int start, int end)
{
    if (end == 1) return String.Empty;
    else return (PrintNumbers(start, --end) + " " + end);
}

Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
int InputNum (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int SumDigits(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigits(num / 10);
}

int number = InputNum("Введите целое число: ");
int sum = SumDigits(number);
System.Console.WriteLine(sum);



Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
***** учесть отрицательные степени


int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

double StepenNumber(int a, int b)
{
    if (b == 0) return 1;
    if (b > 0)
    {
        return a * StepenNumber(a, b - 1);
    }
    elsereturn Math.Round(1 / (a * StepenNumber(a, -b - 1)), 3);
}
int x = InputNum("Введите целое число A: ");
int y = InputNum("Введите целое число B: ");
Console.WriteLine(StepenNumber(x, y));


ЮЛИЯ работает:
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


git init
dotnet new console
dotnet new gitignore
git add .\Program.cs
git commit -m"Start1"


 
int num1 = InputNum("Введите целое число М: ");
int num2 = InputNum("Введите целое число N: ");
Console.WriteLine (SumNumbers(num1, num2)); 
