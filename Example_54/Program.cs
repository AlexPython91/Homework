using System;

// 54. В матрице чисел найти сумму элементов главной диагонали

// Заполнение массива
Console.WriteLine("Двумерный массив: ");

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

// Сумма элементов главной диагонали

int FindDiagonalSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, i];
    }
    return sum;
}


int[,] diagonalSum = new int[5, 5];

diagonalSum = FillArray(diagonalSum, 1, 10);
PrintArray(diagonalSum);
Console.WriteLine($"Сумма элементов главной диагонали = {FindDiagonalSum(diagonalSum)}");
