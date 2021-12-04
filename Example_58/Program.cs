using System;

// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что неполучится перемешать. Матрица должна быть квадратной

int[,] Fillarray(int[,] matrix, int minValue, int maxValue)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return matrix;
}



void PrintArray(int[,] matrix)
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



void SwappingRowsAndColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}


void ChackArray(int[,] matrix, int minValue, int maxValue)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        Console.WriteLine("Ok! Array is changed!");
    }
    else Console.WriteLine("No! We cannot change the array!");
}


int minValue = 1;
int maxValue = 10;

int[,] rowsAndColumnsSwapp = new int[5, 5];

ChackArray(rowsAndColumnsSwapp, minValue, maxValue);
rowsAndColumnsSwapp = Fillarray(rowsAndColumnsSwapp, minValue, maxValue);
PrintArray(rowsAndColumnsSwapp);
Console.WriteLine("----------------");
//ChackArray(rowsAndColumnsSwapp, minValue, maxValue);
SwappingRowsAndColumns(rowsAndColumnsSwapp);
PrintArray(rowsAndColumnsSwapp);

