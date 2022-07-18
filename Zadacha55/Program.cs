﻿// Задайте двумерный массив. Напишите программу, которая заменяет строкина столбцы. В случае, если это невозможно, программа должна вывнсти сообщения пользователя




void AvgMatrix(int[, ] matrix)
{
    Console.WriteLine();
    int x;
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i < j)
                {
                    x = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = x;
                }
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
    }
    else
        Console.WriteLine("Такое невозможно!");

}