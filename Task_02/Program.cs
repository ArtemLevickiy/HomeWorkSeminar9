// Показать натуральные числа от M до N, N и M заданы.

void FillArray(int minNumber, int maxNumber)
{
    if (minNumber <= maxNumber)
    {
        Console.Write($"{minNumber} ");
        minNumber++;
        FillArray(minNumber, maxNumber);
    }
}

Console.WriteLine("Показать натуральные числа от M до N");
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

if (M > N)
{
    int temporary = M;
    M = N;
    N = temporary;
}

FillArray(M, N);