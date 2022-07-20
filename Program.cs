﻿/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49
*/

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++ )
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int IntegMatrix(int[,] matrix1, int[,] matrix2);
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.Getlength(1)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                resultMatrix[i,j] += matrix[i,x] * matrix[x,j];
            }
        }
    }
    return resultMatrix;
}

Console.WriteLine ("Введите число столбцов: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
int[,] firstmatrix = InitMatrix (m,n);
PrintMatrix(firstmatrix);

Console.WriteLine();

int[,] NewMatrix = IntegMatrix (firstmatrix, secondmatrix);
PrintMatrix(NewMatrix);
