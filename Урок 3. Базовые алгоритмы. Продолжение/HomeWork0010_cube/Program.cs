void cube(int num)
{
    for (int i = 1; i <= num; i++)
        Console.WriteLine(i*i);
}
Console.Write("Введите число: ");
cube(Convert.ToInt32(Console.ReadLine()));
