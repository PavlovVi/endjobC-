/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


Console.WriteLine("Введите N: ");
var str = Console.ReadLine() ?? "";

int N = int.Parse(str);

string AddN(int n)
{
    if (n == 1) 
        return "1";
    else
    {
        return n + ", " + AddN(n - 1);
    }

}

Console.WriteLine(AddN(N));
