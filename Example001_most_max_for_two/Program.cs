Console.Write("Введите первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_two = Convert.ToInt32(Console.ReadLine());

if(number_one > number_two)
{
Console.WriteLine($"Первое число: {number_one} - максимальное");
// Console.WriteLine($"Второе число: {number_two} - минимальное");
}
else
{
Console.WriteLine($"Второе число: {number_two} - максимальное");
// Console.WriteLine($"Первое число: {number_one} - минимальное");
}
