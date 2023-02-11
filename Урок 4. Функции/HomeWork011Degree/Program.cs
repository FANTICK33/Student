void Degree(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * number;
    }
    Console.WriteLine($"{result} возведенное число {number} в натуральную степень {degree}");
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int deg = Convert.ToInt32(Console.ReadLine());
Degree(num,deg);
