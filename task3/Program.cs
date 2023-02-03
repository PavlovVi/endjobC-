// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("A({0},{1}) = {2}", m, n, Akkerman(m, n));

static int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}



