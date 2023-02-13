int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    array[i] = new Random().Next(100,1000);//Заполняем случайными числами диапозоном от 100 до 999
    return array;
}

int Count(int[] MyArray)
{
    int cnt = 0;
    for (int i = 0; i < MyArray.Length; i++)
    if (MyArray[i]%2==0)
        cnt += 1;
    return cnt;
}

void PrintArray(int[] MyArray)
{
    Console.Write("Created array: ");
    for (int i = 0; i < MyArray.Length; i++)
        Console.Write(MyArray[i]+" ");
}
void PrintCount(int cnt)
{
    Console.Write("\nNumber of even numbers in array: " + cnt);
}

Console.Write("Input the length of new array: ");
int Size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandomArray(Size);
int Cnt = Count(MyArray);
PrintArray(MyArray);
PrintCount(Cnt);
