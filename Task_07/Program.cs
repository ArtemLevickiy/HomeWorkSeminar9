// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int FillArray(int numberA, int numberB, int amountNumber)
{
    int numberC = 0;
    if (amountNumber <= 1)
    {
        numberC = numberA + numberB;
    }
    if (amountNumber + 1 > 1)
    {
        numberC = numberA + numberB;
        numberA = numberB;
        numberB = numberC;
        amountNumber = amountNumber - 1;
        Console.Write($"{numberC} ");
        FillArray(numberA, numberB, amountNumber);
    }
    return numberC;
}

Console.Clear();
Console.WriteLine("Написать программу показывающую первые N чисел, для которых каждое следующее равно сумме двух предыдущих");
Console.Write("Введите первое число : ");
int А = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число : ");
int B = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите нужное количество дополнительных чисел : ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.Write($"{А} ");
Console.Write($"{B} ");
FillArray(А, B, N);
