﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите число a: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.WriteLine("Большее число " + num1);
}
else
{
    Console.WriteLine("Большее число " + num2);
}
