int IsSecond(int number)
{
    int SecondNumber = (number % 100) / 10;
    return SecondNumber;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Second = IsSecond(number);

Console.WriteLine($"{Second} - второе цифра, из числа {number}");
