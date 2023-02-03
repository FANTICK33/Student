Console.WriteLine("Введите три числа по очереди:");
int number_one = Convert.ToInt32(Console.ReadLine());
int number_two = Convert.ToInt32(Console.ReadLine());
int number_three = Convert.ToInt32(Console.ReadLine());

if(number_one > number_two)
{
    if(number_one > number_three)
    {
        Console.WriteLine($"Первое число: {number_one} - большее");
    }
    else
    {
        Console.WriteLine($"Третье число: {number_three} - большее");
    }
}
else
{
    if(number_two > number_three)
    {
        Console.WriteLine($"Второе число: {number_two} - большее");
    }
    else
    {
        Console.WriteLine($"Третье число: {number_three} - большее");
    }
}
