//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //int x = Convert.ToInt32(Console.ReadLine());
            int x = new Random().Next(1, 100);
            matrix[i, j] = x;
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int f = j + 1; f < matrix.GetLength(1); f++)
            {
                if (matrix[i, f] < matrix[i, j])
                {
                    x = matrix[i, j];
                    matrix[i, j] = matrix[i, f];
                    matrix[i, f] = x;

                }

            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
matrix = CreateMatrix(matrix);
AvgMatrix(matrix);
