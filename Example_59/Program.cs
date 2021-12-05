using System;

// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] FillMatrix(int[,] matrix, int leftBound, int rightBound)
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


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int FindSmallestSumTlements(int[,] matr)
{
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = matr[i, j] + matr[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            index = i;
        }
    }
    return index;

}


int leftBound = 1;
int rightBound = 10;

int[,] findSmallestSum = new int[4, 6];

FillMatrix(findSmallestSum, leftBound, rightBound);
PrintMatrix(findSmallestSum);
System.Console.WriteLine();
int index = FindSmallestSumTlements(findSmallestSum);
System.Console.WriteLine($"The row with the smallest sum of elements = {index}");

