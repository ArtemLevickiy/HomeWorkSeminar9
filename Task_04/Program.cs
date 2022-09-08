// Найти сумму цифр числа.

int InputNumbers(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int SplitNumber(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SplitNumber(number / 10);
}
Console.Clear();
int number = InputNumbers("Найти сумму цифр числа: ");
Console.WriteLine(SplitNumber(number));