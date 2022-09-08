// Найти сумму элементов от M до N, N и M заданы.

void SumArray(int minNumber, int maxNumber)
{
    int min = minNumber;
    int max = maxNumber;
    int sum = 0;
    {
        if (min > max)
        {
            min = maxNumber;
            max = minNumber;
        }
        while (min <= max)
        {
            Console.Write($"{min} ");
            sum=sum+min;
            min++;
        }
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов = {sum}");
    }
}


Console.WriteLine("Найти сумму элементов от M до N");
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

SumArray(M, N);