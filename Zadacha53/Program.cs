// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива









void AvgMatrix(int[, ] matrix)
{
    Console.WriteLine();
    int x;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        x = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = x;
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
