using System;

// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива. 


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

// Печать массива

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


int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, minPosition]) minPosition = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = temp;
        }
    }
    return array;
}


int[,] orderingArray = new int[5, 5];

orderingArray = FillMatrix(orderingArray, 1, 10);
PrintMatrix(orderingArray);
SortArray(orderingArray);
System.Console.WriteLine();
PrintMatrix(orderingArray);
