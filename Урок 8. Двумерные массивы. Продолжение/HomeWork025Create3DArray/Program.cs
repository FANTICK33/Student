int[,,] Create3DArray(){
    int[,,] Array = new int[2,2,2];
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            for (int k = 0; k < Array.GetLength(2); k++)
                Array[i,j,k] = new Random().Next(10,100);
    return Array;
}
void Print3DArray(int[,,] Array){
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
                Console.Write($"{Array[i,j,k]}" + (i,j,k) + " ");
            Console.WriteLine();
        }
}

Print3DArray(Create3DArray());
