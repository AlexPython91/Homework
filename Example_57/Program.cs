using System;

// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива. 


int[,] FillArray(int[,] array, int leftBound, int rightBound)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftBound, rightBound);
        }
    }
    return array;
}

// Печать массива

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива. 

int[,] OrderingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int index = array[0,0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[i, j] + 1)
            {
                //index = index[i, j] + 1;
            }
        }
    }
    return array;
}


int[,] orderingArray = new int[6, 10];

orderingArray = FillArray(orderingArray, 1, 10);
PrintArray(orderingArray);
OrderingArray(orderingArray);


// diagonalSum = FillArray(diagonalSum, 1, 10);
// PrintArray(diagonalSum);
// Console.WriteLine($"Сумма элементов главной диагонали = {FindDiagonalSum(diagonalSum)}");