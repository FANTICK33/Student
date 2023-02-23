double[,] CreateTwoDimensionalArray() //Метод создания двумерного массива.
{
    Console.Write("Input the number of the rows two-dimensional array: "); //Задаем кол-во строк.
    int Rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of the columns two-dimensional array: "); //Задаем кол-во столбцов.
    int Columns = Convert.ToInt32(Console.ReadLine());
    double[,] Array = new double [Rows, Columns];
    for (int i = 0; i < Rows; i++)
        for (int j = 0; j < Columns; j++)
            Array[i,j] = (new Random().NextDouble()* 2 - 1) * 10; //Заполнение случайными вещественными числами.
    return Array;
}

double[,] DescendingOrder(double[,] Array) //Метод сортировки двумерного массива в порядке убывания.
{
    for (int i = 0; i < Array.GetLength(0); i++) // перечисление строк
    {
        for (int j = 0; j < Array.GetLength(1); j++) // перечисление символов(столбцов)
        {
            for (int k = i; k < Array.GetLength(0); k++) //перечесления строк для проверки
            {
                for (int w = 0; w < Array.GetLength(1); w++)
                {
                    if(Array[i,j] > Array[k,w])
                    {
                        double Element = Array[i,j];
                        Array[i,j] = Array[k,w];
                        Array[k,w] = Element;
                    }
                }
            }
        }
    }
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

// Вызов методов.
double[,] TwoDimensionalArray = CreateTwoDimensionalArray();
ShowArray(TwoDimensionalArray);

double[,] DescendingOrderArray = DescendingOrder(TwoDimensionalArray);
ShowArray(DescendingOrderArray);
