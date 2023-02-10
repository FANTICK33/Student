void distance(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    Console.WriteLine(
    Math.Round(Math.Sqrt(
        Math.Pow(Bx-Ax,2)+
        Math.Pow(By-Ay,2)+
        Math.Pow(Bz-Az,2)),3));
}

Console.WriteLine("Введите кординаты точки A");
double Ax = Convert.ToDouble(Console.ReadLine());
double Ay = Convert.ToDouble(Console.ReadLine());
double Az = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите кординаты точки B");
double Bx = Convert.ToDouble(Console.ReadLine());
double By = Convert.ToDouble(Console.ReadLine());
double Bz = Convert.ToDouble(Console.ReadLine());

distance(Ax,Ay,Az,Bx,By,Bz);
