int[,] CreateTwoDimensionalArray(int rows, int columns) //Метод создания двумерного массива.
{
    int[,] Array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            Array[i,j] = new Random().Next(0,100);
    return Array;
}
void ShowArray(int[,] Array) //Вывод двумерного массива в консоль.
{
    int rows = Array.GetUpperBound(0) + 1;
    int columns = Array.GetUpperBound(1) + 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write($"{Array[i, j]} \t");
        Console.WriteLine();
    }
}
Console.Write("Input the number of the rows two-dimensional array: "); //Задаем кол-во строк.
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of the columns two-dimensional array: "); //Задаем кол-во столбцов.
int Columns = Convert.ToInt32(Console.ReadLine());
// Вызов методов.
int[,] TwoDimensionalArray = CreateTwoDimensionalArray(Rows,Columns);
ShowArray(TwoDimensionalArray);
