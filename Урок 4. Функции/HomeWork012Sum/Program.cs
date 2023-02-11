void Sum(int num)
{
    int result = 0;
    int sum = 0;
    while (num != 0)
        {
            result = num % 10;
            num = num / 10;
            sum = sum + result;
        }
    Console.WriteLine(sum);
}
Console.WriteLine("Введите число: ");
int MyNum = Convert.ToInt32(Console.ReadLine());
Sum(MyNum);
