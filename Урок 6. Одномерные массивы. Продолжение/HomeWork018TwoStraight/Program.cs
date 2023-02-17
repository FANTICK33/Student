void TwoStraight(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые совпадают");
    if (k1==k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b1-b2)/(k2-k1);
        double y = (k2*b1-k1*b2)/(k2-k1);
        Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}
Console.WriteLine("Введите точки двух прямых");
Console.Write("b1: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double B2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double K2 = Convert.ToDouble(Console.ReadLine());
TwoStraight(B1, K1, B2, K2);
