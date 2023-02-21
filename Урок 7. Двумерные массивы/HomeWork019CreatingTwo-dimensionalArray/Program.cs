double[,] CreateTwoDimensionalArray(int rows, int columns) //Метод создания двумерного массива.
{
    double[,] Array = new double [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            Array[i,j] = (new Random().NextDouble()* 2 - 1) * 10; //Заполнение случайными вещественными числами.
    return Array;
}
void ShowArray(double[,] Array) //Вывод двумерного массива в консоль.
{
    int rows = Array.GetUpperBound(0) + 1;
    int columns = Array.GetUpperBound(1) + 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write($"{Math.Round(Array[i, j],1)} \t");
        Console.WriteLine();
    }
}
Console.Write("Input the number of the rows two-dimensional array: "); //Задаем кол-во строк.
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of the columns two-dimensional array: "); //Задаем кол-во столбцов.
int Columns = Convert.ToInt32(Console.ReadLine());
// Вызов методов.
double[,] TwoDimensionalArray = CreateTwoDimensionalArray(Rows,Columns);
ShowArray(TwoDimensionalArray);
