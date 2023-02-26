int[,] Create2DArray(int size)
{
    int[,] Array = new int[size, size];
    int rows = Array.GetLength(0);
    int columns = Array.GetLength(1);
    int number = 1;
    int muscle = 0;
    int cycles = (rows / 2) + (rows % 2);
    for (int v = 0; v < cycles; v++)
    {
        //1 вложенный цикл
        for (int i = muscle; i < columns - muscle; i++)
        {
            Array[muscle, i] = number;
            number++;
        }
        number--;
        //2 вложенный цикл
        for (int j = muscle; j < rows - muscle; j++)
        {
            Array[j, rows - 1 - muscle] = number;
            number++;
        }
        number--;
        //3 вложенный цикл
        for (int k = (rows - 1 - muscle); k >= muscle; k--)
        {
            Array[columns - 1 - muscle, k] = number;
            number++;
        }
        number--;
        //4 вложенный цикл
        for (int z = (rows - 1 - muscle); z >= 1 + muscle; z--)
        {
            Array[z, muscle] = number;
            number++;
        }
        muscle++;
    }

    return Array;
}
void Print2DArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
            Console.Write(Array[i, j] + "\t");
        Console.WriteLine();
        Console.WriteLine();
    }
}
Console.Write("Enter the size of the cycle: ");
int size = Convert.ToInt32(Console.ReadLine());
Print2DArray(Create2DArray(size));
