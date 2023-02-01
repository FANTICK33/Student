﻿Console.Write("Введите первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_two = Convert.ToInt32(Console.ReadLine());

if(number_one > number_two)
{
Console.WriteLine($"Первое число: {number_one} - большее");
Console.WriteLine($"Второе число: {number_two} - меньшее");
}
else
{
Console.WriteLine($"Второе число: {number_two} - большее");
Console.WriteLine($"Первое число: {number_one} - меньшее");
}
