int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,10);
    }
    return array;
}

int Sum(int[] MyArray)
{
    int sum = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if(i%2!=0)
        sum += MyArray[i];
    }
    return sum;
}

void PrintArray(int[] MyArray)
{
    Console.Write("Created array: ");
    for (int i = 0; i < MyArray.Length; i++)
    {
        Console.Write(i + "-" + MyArray[i] + ", ");
    }
}

void PrintSum(int Sum)
{
    Console.WriteLine("\nThe sum under odd indexes: " + Sum);
}

Console.Write("Input the length of new array: ");
int Size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandomArray(Size);
PrintArray(MyArray);

int SumUnderOddIndexes = Sum(MyArray);
PrintSum(SumUnderOddIndexes);
