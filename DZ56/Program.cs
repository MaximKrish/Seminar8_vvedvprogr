// Залайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.





void AvgMatrix(int[, ] matrix)
{
    Console.WriteLine();
    int minrow = 1000;
    int kmin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow = sumrow + matrix[i, j];
        }
        if (sumrow < minrow)
        {
            minrow = sumrow;
            kmin = i + 1;
        }
    }
    Console.WriteLine(minrow + " " + kmin);

}


