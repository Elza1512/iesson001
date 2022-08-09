// 1. Напишите программу, которая на вход принимает 2 числа и проверяет,является лт первое число квадратом второго.
// а = 25, b  = 5 -> да
// а = 2, b  = 10 -> нет
// а = 9, b  = -3 -> да
// а = -3, b  = 9 -> нет


Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int b = Convert.ToInt32(System.Console.ReadLine());

if(b*b == a) Console.WriteLine($"число {a} является квадратом числа {b}");
else Console.WriteLine($"число {a} НЕ является квадратом числа {b}");
