using System;

// 1. Заполнить двумерный массив размером n*m случайными числами

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

//2. Напечатать двумерный массив на экран

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

//3. Найти наибольший элемент двумерного массива 

int MaxNumberInArray(int[,] arr)
{
    int maxNum = arr[0, 0];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (maxNum < arr[i, j]) maxNum = arr[i, j];
        }
    }
    return maxNum;
}


//4. Найти сумму элементов двумерного массива

int FillSumArray(int[,] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
    }
    return sum;
}



int n = 5;
int m = 5;

int[,] coolArray = new int[n, m];

coolArray = FillArray(coolArray, 1, 10);
PrintArray(coolArray);
// Console.WriteLine($"Наш массив: {coolArray}");

int findMax = MaxNumberInArray(coolArray);
Console.WriteLine($"Максимальное значение массива = {findMax}" );

int sum = FillSumArray(coolArray);
Console.WriteLine($"Сумма = {sum}");