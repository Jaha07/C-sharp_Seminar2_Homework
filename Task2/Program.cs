// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine()!);
int result = number / 100;
result = Math.Abs(result);
if (result < 1)
{
    Console.WriteLine("There is no third number");
}
else
{
    result %= 10;
    Console.WriteLine($"Your number {number}, third digit {result}");
}