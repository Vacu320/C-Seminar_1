// Первое домашнее задание. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    System.Console.WriteLine($"max = {numberA}");
}
else
{
    System.Console.WriteLine($"max = {numberB}");
}
