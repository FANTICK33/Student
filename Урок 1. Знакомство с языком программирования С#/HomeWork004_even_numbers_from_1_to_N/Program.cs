Console.Write("Введите число для нахождения четных чисел от 1 до ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (count < number)
{
    count++;
    if(count%2 == 0)
    {
        Console.WriteLine(count);
    }
}
