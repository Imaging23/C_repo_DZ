﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
Console.WriteLine($"Большое число - {number1}");
Console.WriteLine($"Меньшее число - {number2}");
}
else
{
Console.WriteLine($"Большое число - {number2}");
Console.WriteLine($"Меньшее число - {number1}");
}

