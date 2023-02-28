void RecursionOfNaturalNumbers(int N)
{
    int zero = 0;
    if (zero < N)
    {
        Console.Write(N + ", ");
        N--;
        RecursionOfNaturalNumbers(N);
    }
}
Console.Write("Input number: ");
int Number = Convert.ToInt32(Console.ReadLine());
RecursionOfNaturalNumbers(Number);
