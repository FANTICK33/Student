try
{
    int[,] Create2DArray1() { //Метод создания первого двумерного массива.
        Console.WriteLine("|Create 2D array № 1|");
        Console.Write("Input the number of the rows: ");  //Задаем кол-во строк.
        int Rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the number of the columns: ");  //Задаем кол-во столбцов.
        int Columns = Convert.ToInt32(Console.ReadLine());
        int[,] Array1 = new int[Rows,Columns];
        int Array1Rows = Array1.GetLength(0);
        int Array1Columns = Array1.GetLength(1);
        for (int i = 0; i < Array1Rows; i++)
            for (int j = 0; j < Array1Columns; j++)
            {
                Console.Write((i,j) + " = ");
                Array1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        Console.WriteLine();
        return Array1;
    }
    int[,] Create2DArray2() { //Метод создания второго двумерного массива.
        Console.WriteLine("|Create 2D array № 2|");
        Console.Write("Input the number of the rows: ");  //Задаем кол-во строк.
        int Rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the number of the columns: ");  //Задаем кол-во столбцов.
        int Columns = Convert.ToInt32(Console.ReadLine());
        int[,] Array2 = new int[Rows,Columns];
        int Array2Rows = Array2.GetLength(0);
        int Array2Columns = Array2.GetLength(1);
        for (int i = 0; i < Array2Rows; i++)
            for (int j = 0; j < Array2Columns; j++)
            {
                Console.Write((i,j) + " = ");
                Array2[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        Console.WriteLine();
        return Array2;
    }
    void Show2DArray(int[,] Array) { //Вывод двух двумерного массива в консоль.
        int rows = Array.GetUpperBound(0) + 1;
        int columns = Array.GetUpperBound(1) + 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
                Console.Write($"{Array[i, j]} ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    int[,] ProductOfTwoMatrices(int[,] Array1,int[,] Array2) { //Метод считающий произведение двух матриц
        int Array1Rows = Array1.GetLength(0);
        int Array1Columns = Array1.GetLength(1);
        int Array2Rows = Array2.GetLength(0);
        int Array2Columns = Array2.GetLength(1);
        int[,] Array = new int[Array2Rows,Array2Columns];
        for (int i = 0; i < Array1Rows; i++)
        {
            for (int j = 0; j < Array2Columns; j++)
                for (int k = 0; k < Array1Columns; k++)
                    Array[i,j] += Array1[i,k] * Array2[k,j];
        }
        return Array;
    }
    //Вызов методов
    int[,] Array1 = Create2DArray1();
    int[,] Array2 = Create2DArray2();
    Show2DArray(Array1);
    Show2DArray(Array2);
    int[,] NewMatrice = ProductOfTwoMatrices(Array1,Array2);
    Console.WriteLine("Product of two matrices");
    Show2DArray(NewMatrice);
}
catch (System.IndexOutOfRangeException)
{
    Console.WriteLine("Индекс первой матрицы находился за пределами массива, попробуйте снова.");
}
