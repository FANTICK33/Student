int AckermannFunction(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (M != 0 && N == 0)
        return AckermannFunction(M - 1, 1);
    else
        return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
}
Console.Write("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(M, N);
Console.WriteLine(result);
