using System;

// 61. Найти произведение двух матриц


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
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    var matrixC = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (var i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (var j = 0; j < secondMatrix.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (var k = 0; k < firstMatrix.GetLength(0); k++)
            {
                matrixC[i, j] = matrixC[i, j] + firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return matrixC;
}

int[,] FirstMatrix = new int[2, 2];
int[,] SecondMatrix = new int[2, 2];

int leftBound = 1;
int rightBound = 10;

System.Console.WriteLine("First matrix: ");
FillMatrix(FirstMatrix, leftBound, rightBound);
PrintMatrix(FirstMatrix);
System.Console.WriteLine("Second matris: ");
FillMatrix(SecondMatrix, leftBound, rightBound);
PrintMatrix(SecondMatrix);
System.Console.WriteLine("Matrix product: ");
PrintMatrix(MatrixMultiplication(FirstMatrix, SecondMatrix));