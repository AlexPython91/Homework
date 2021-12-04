using System;

// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] FillArray(int[,] matrix, int leftBound, int rightBound)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftBound, rightBound);
        }
    }
    return matrix;
}

Console.WriteLine("This is my array: ");

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10)
            {
                Console.Write($"-({matrix[i, j]})-   ");
            }
            else Console.Write($"-({matrix[i, j]})-   ");
        }
        Console.WriteLine();
    }
}


double[] FindArithmeticMean(int[,] matr)
{
    double[] result = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
            result[j] = sum / matr.GetLength(1);
        }
    }
    return result;
}


void PrintArray(double[] matrix)
{
    Console.WriteLine("ArithmeticMean: ");
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"({matrix[i]})   ");
    }
}

int leftBound = 1;
int rightBound = 10;

int[,] findArithmeticMean = new int[5, 5];

findArithmeticMean = FillArray(findArithmeticMean, leftBound, rightBound);
PrintMatrix(findArithmeticMean);
Console.WriteLine();
FindArithmeticMean(findArithmeticMean);
double[] ArithmeticMean = FindArithmeticMean(findArithmeticMean);
PrintArray(ArithmeticMean);