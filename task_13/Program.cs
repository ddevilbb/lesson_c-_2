// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.Через строку решать нельзя.

Console.Clear();
Console.WriteLine("Программа, которая выводит третью цифру заданного числа " +
                  "или сообщает, что третьей цифры нет");

try
{
    Console.Write("Введите трёзначное число: ");
    int number = int.Parse(Console.ReadLine()!);
    int numberDigit = number != 0 ? (int)Math.Log10(Math.Abs(number)) + 1 : 1;
    if (numberDigit < 3)
    {
        throw new Exception($"{number} -> третьей цифры нет");
    }
    Console.WriteLine("{0} -> {1}", number, number / Convert.ToInt32(Math.Pow(10, numberDigit - 3)) % 10);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
