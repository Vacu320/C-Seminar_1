// Второе домашнее задание. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");

int numberA = int.Parse(Console.ReadLine());

int numberB = int.Parse(Console.ReadLine());

int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
System.Console.WriteLine($"максимальное из этих чисел {max}");


