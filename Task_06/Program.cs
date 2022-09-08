// Написать программу возведения числа А в целую стень B.

double FillArray(double numberA, double degree)
{
    if (numberA > 0 && degree > 0 || numberA < 0 && degree > 0)
        return numberA * FillArray(numberA, degree - 1);
    else if (degree <0 )
        return 1/(numberA * FillArray(numberA, -degree - 1));
    else if (degree == 1)
        return numberA;
    else if (degree == 0)
        return 1;
    else if (numberA == 0)
        return 0;
    return numberA;
}

Console.Clear();
Console.WriteLine("Написать программу возведения числа А в целую стень B");
Console.Write("Введите А : ");
double А = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите B : ");
double B = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(FillArray(А, B));