// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели," +
                  " и проверяет, является ли этот день выходным.");

while (true)
{
    try
    {
        Console.Write("Введите номер дня недели(от 1 до 7): ");
        int number = int.Parse(Console.ReadLine()!);
        if (number is < 1 or > 7)
        {
            throw new Exception("Допустимые значения: любое число от 1 до 7");
        }
        Console.WriteLine("{0} -> {1}", number, (number > 5 ? "да" : "нет"));
        break;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}