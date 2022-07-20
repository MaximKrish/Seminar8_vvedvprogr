//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

void SumMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixsum = new int[4, 4];
    Console.WriteLine();
    for (int i = 0; i < matrixsum.GetLength(0); i++)
    {
        for (int j = 0; j < matrixsum.GetLength(1); j++)
        {
            matrixsum[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write(matrixsum[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] matrix1 = new int[4, 4];
int[,] matrix2 = new int[4, 4];
matrix1 = CreateMatrix(matrix1);
Console.WriteLine();
matrix2 = CreateMatrix(matrix2);
SumMatrix(matrix1, matrix2);

