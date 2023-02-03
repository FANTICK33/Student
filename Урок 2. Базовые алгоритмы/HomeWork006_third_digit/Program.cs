int IsThird(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
            {
                number = number / 10;
            }
        result = number % 10;
    }
    return result;

}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Third = IsThird(number);
Console.WriteLine($"{Third} - третья цифра, из числа - {number}");
