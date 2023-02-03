string Weekends(int Day)
{
    string result = "Нет";
    if (Day == 6 || Day == 7)
    {
        result = "Да";
    }
    return result;
}

Console.Write("Введите день недели: ");
int Day = Convert.ToInt32(Console.ReadLine());

string IsDate = Weekends(Day);
Console.WriteLine(IsDate);
