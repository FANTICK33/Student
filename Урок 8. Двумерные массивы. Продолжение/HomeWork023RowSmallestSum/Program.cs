double[,] CreateTwoDimensionalArray()  //Метод создания двумерного массива.
{
    Console.Write("Input the number of the rows two-dimensional array: ");  //Задаем кол-во строк.
    int Rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of the columns two-dimensional array: ");  //Задаем кол-во столбцов.
    int Columns = Convert.ToInt32(Console.ReadLine());
    double[,] Array = new double [Rows, Columns];
    for (int i = 0; i < Rows; i++)
        for (int j = 0; j < Columns; j++)
            Array[i,j] = (new Random().NextDouble()* 2 - 1) * 10;  //Заполнение случайными вещественными числами.
    return Array;
}

void ShowArray(double[,] Array) //Вывод двумерного массива в консоль.
{
    Console.WriteLine("");
    int rows = Array.GetUpperBound(0) + 1;
    int columns = Array.GetUpperBound(1) + 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write($"{Math.Round(Array[i, j],1)} \t");
        Console.WriteLine("");
    }
}

int SmallestRowSum(double[,] Array)
{
    double minsum = 100;
    double sum = 0;
    int index = 0;
    for (int i = 0; i < Array.GetLength(0); i++)  //Перечисление строк
        {
            sum = 0;  //Обновление суммы для новой строки
            for (int j = 0; j < Array.GetLength(1); j++)  //Перечисление столбцов
                sum += Array[i,j];
            if(sum < minsum)
            {
                minsum = sum;
                index = i+1;  //Сохранение номера строки с минимальной суммой
            }
        }
    return index;
}

// Вызов методов.
double[,] TwoDimensionalArray = CreateTwoDimensionalArray();
ShowArray(TwoDimensionalArray);
int SmallestRow = SmallestRowSum(TwoDimensionalArray);
Console.WriteLine($"The smallest sum in -> {SmallestRow} row");
