void RecursionOfNaturalNumbers(int Num)
{
    Console.Write(Num + " ");
    if (Num > 1)
        RecursionOfNaturalNumbers(Num - 1);
}
Console.Write("Input number: ");
int Num = Convert.ToInt32(Console.ReadLine());
RecursionOfNaturalNumbers(Num);
