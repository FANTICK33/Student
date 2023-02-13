int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0,100);
    return array;
}

int DifferenceMaxMin(int[] MyArray)
{
    int max = 0;
    int min = 100;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if(MyArray[i]>max)
            max = MyArray[i];
        if(MyArray[i]<min)
            min = MyArray[i];
    }
    int sum = max - min;
    return sum;
}

void PrintArray(int[] MyArray)
{
    Console.Write("Created array: ");
    for (int i = 0; i < MyArray.Length; i++)
    {
        Console.Write(MyArray[i] + ", ");
    }
}

void PrintDifferenceMaxMin(int Sum)
{
    Console.WriteLine("\nDifference between max and min: " + Sum);
}

Console.Write("Input the length of new array: ");
int Size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandomArray(Size);
PrintArray(MyArray);

int difference_max_min = DifferenceMaxMin(MyArray);
PrintDifferenceMaxMin(difference_max_min);
