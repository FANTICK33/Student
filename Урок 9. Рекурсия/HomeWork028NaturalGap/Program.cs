int NaturalNumbers(int M, int N)
{
    int Sum = 0;
    if (M < N)
    {
        for (int i = M; i <= N; i++)
        {
            Sum += i;
        }
    }
    return Sum;
}
Console.Write("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = NaturalNumbers(M, N);
Console.WriteLine(sum);
