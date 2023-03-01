// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа. Через строку решать нельзя.

Console.Clear();
Console.WriteLine("Программа, которая принимает на вход трёхзначное число " +
                  "и на выходе показывает вторую цифру этого числа.");

while (true)
{
    try
    {
        Console.Write("Введите трёзначное число: ");
        int number = int.Parse(Console.ReadLine()!);
        if (number is < 100 or > 999)
        {
            throw new Exception("Допустимые значения: любое трёхзначное число");
        }
        Console.WriteLine("{0} -> {1}", number, number / 10 % 10);
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
