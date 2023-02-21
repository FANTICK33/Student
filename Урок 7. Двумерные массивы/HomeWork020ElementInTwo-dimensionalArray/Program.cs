int[,] CreatTwoDimensionalArray(int rows, int columns) //Создание массива.
{
    int[,] Array = new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array[i,j] = new Random().Next(0,100);
        }
    }
    return Array;
}

void ShowArray(int[,] Array) //Вывод массива в терминал.
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
void ShowNumber(int[,] MyArray, int Row, int Column) //Вывод элемента по индексу.
{
    try
    {
        Console.WriteLine(MyArray[Row-1,Column-1]);
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("числа с такими индексами в массиве нет");
    }
}

// Запрос пользователю, на ввод размера создаваемого двумерного массива.
Console.Write("Input the number of the rows two-dimensional array: "); //Задаем кол-во строк.
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of the columns two-dimensional array: "); //Задаем кол-во столбцов.
int Columns = Convert.ToInt32(Console.ReadLine());
// Вызов методов.
int[,] MyArray = CreatTwoDimensionalArray(Rows,Columns);
ShowArray(MyArray);

//Запрос пользователю, на ввод позиции элемента из двумерного массива.
Console.Write("Input numbers the row: ");
int Row =Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers the column: ");
int Column = Convert.ToInt32(Console.ReadLine());
ShowNumber(MyArray,Row,Column);
