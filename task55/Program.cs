﻿// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
 {
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j =0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = rand.Next(leftRange, rightRange + 1);
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
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("введите m "); //число строк
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("введите n "); //число строк
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);

int[,] reversmatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            reversmatrix[i, j] = matrix [j, i];
        }
        Console.WriteLine();
    }

    PrintMatrix(reversmatrix);