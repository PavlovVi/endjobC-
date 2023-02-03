/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

 int M, N, sum = 0;
Console.WriteLine("Введите M: ");
M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = M; i <= N; i++)
{
    if (i > 0)
    {
        sum += i;
    }
}

Console.WriteLine("Сумма натуральных чисел между " + M + " и " + N + " равна: " + sum);
Console.ReadLine();