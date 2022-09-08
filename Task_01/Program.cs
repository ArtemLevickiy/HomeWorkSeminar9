// Показать натуральные числа от N до 1, N задано

int FillArray(int numberN)
{
    if (numberN < 1)
    {
        Console.Write($"{numberN} ");
        numberN++;
        FillArray(numberN);
    }
    else if (numberN == 1)
        Console.Write($"{1}");
    else if (numberN > 1)
        Console.WriteLine("Введите число меньше '1' ");
    return 1;
}

Console.Clear();
Console.WriteLine("Показать натуральные числа от N до 1");
Console.Write("Введите N: ");
int userNumber = int.Parse(Console.ReadLine() ?? "0");


FillArray(userNumber);