int InputNambers(int check)
{
    int count = 0;
    for (int i = 0; i < check; i++)
    {
        Console.Write("Enter the number "+(i+1)+": ");
        if (Convert.ToInt32(Console.ReadLine())>0)
            count += 1;
    }
    return count;
}
Console.Write("How many digits to check?: ");
Console.WriteLine(InputNambers(Convert.ToInt32(Console.ReadLine()))+" - more than zero");
