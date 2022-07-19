// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

int[, ] CreateMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //int x = Convert.ToInt32(Console.ReadLine());
            int x = new Random().Next(1, 1000);
            matrix[i , j] = x;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

    return matrix;
}


void AvgMatrix(int[,] matrix)
{
    Console.WriteLine();
    int x;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        x = matrix[0, i];                                       // x = matrix[1, i];  поменять местами вторую и предпоследнюю
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];      // matrix[1, i] = matrix[matrix.GetLength(0) - 2, i];
        matrix[matrix.GetLength(0) - 1, i] = x;                 //matrix[matrix.GetLength(0) - 2, i] = x;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

int[, ] matrix = new int[4, 4];
matrix = CreateMatrix(matrix);
AvgMatrix(matrix);
