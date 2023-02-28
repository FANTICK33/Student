void NaturalInterval(int M, int N)
{
    Console.Write(M + " ");
    if (M > N)
        NaturalInterval(M - 1, N);
    if (M < N)
        NaturalInterval(M + 1, N);
}
Console.Write("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
NaturalInterval(M, N);
