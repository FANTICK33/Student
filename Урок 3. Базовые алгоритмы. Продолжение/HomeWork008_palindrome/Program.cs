bool Palindrom(string num)
{
    for (int i = 0; i < num.Length / 2; i++)
        if (num[i] != num[num.Length - i - 1])
            return false;
    return true;
}
Console.Write("Ввидите число: ");
string Number = Console.ReadLine();
System.Console.WriteLine(Palindrom(Number));
