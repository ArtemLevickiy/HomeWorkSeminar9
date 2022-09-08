// Написать программу вычисления функции Аккермана

int S(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n > 0 && m == 0)
        return S(n - 1, 1);
    else if (n > 0 && m > 0)
        return S(n - 1, S(n, m - 1));
    return S(n, m);
}

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(S(n, m));