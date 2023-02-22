double[,] Creat2DArray() //Создание массива.
{
    Console.Write("Input the number of the rows two-dimensional array: "); //Задаем кол-во строк.
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of the columns two-dimensional array: "); //Задаем кол-во столбцов.
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] Array = new double [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array[i,j] = new Random().NextDouble()*100;
        }
    }
    return Array;
}
void Show2DArray(double[,] Array) //Вывод массива в терминал.
{
    Console.WriteLine("");
    Console.WriteLine("2DArray");
    int rows = Array.GetUpperBound(0) + 1;
    int columns = Array.GetUpperBound(1) + 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            Console.Write($"{Math.Round(Array[i, j],2)} \t");
        Console.WriteLine();
    }
}
double[] ArithmeticMean(double[,] Array)
{

    int rows = Array.GetUpperBound(0) + 1;
    int columns = Array.GetUpperBound(1) + 1;
    double[] ArrayOfArithmeticMean = new double [columns];
    double sum = 0;
    for (int i = 0; i < columns; i++)
    {
        sum = 0;
        for (int j = 0; j < rows; j++)
            {
                sum += Array[j,i];
            }
        ArrayOfArithmeticMean[i] = sum / rows;
    }
    return ArrayOfArithmeticMean;
}
void ShowArray(double[] Array)
{
    Console.WriteLine("");
    Console.WriteLine("Arithmetic mean");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Math.Round(Array[i],2)};   ");
    }
}

double[,] NewArray = Creat2DArray();
Show2DArray(NewArray);

double[] Array = ArithmeticMean(NewArray);
ShowArray(Array);
