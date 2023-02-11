int[] Array(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число для индекс - {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("Полученный массив: [");
    for (int i = 0; i < array.Length-1; i++)
        Console.Write(array[i] + ", ");
    Console.Write(array[array.Length-1]);
    Console.WriteLine("]");
}

System.Console.Write("Введите длину нового массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = Array(size);
PrintArray(MyArray);
