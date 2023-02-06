// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Enter your number: ");
int week = int.Parse(Console.ReadLine()!);
if (week == 6 || week == 7)
{
    Console.WriteLine("Weekend");
}
else if (week >= 1 && week <= 5)
{
    Console.WriteLine("Weekday");
}