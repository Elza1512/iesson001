﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int b = Convert.ToInt32(System.Console.ReadLine());

if (a > b)
Console.WriteLine("{0} - max, {1} - min", a, b);
else Console.WriteLine("{0} - max, {1} - min", b, a);






