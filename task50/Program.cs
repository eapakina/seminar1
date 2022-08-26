// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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

Console.Write("введите n "); //число столбцов
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);


Console.Write("введите индекс искомого элемента через энтер "); 
int indm = Convert.ToInt32(Console.ReadLine());
int indn = Convert.ToInt32(Console.ReadLine());

if ((indm > m) || (indn > n) || (indn <= 0) || (indn <= 0))
{
    Console.Write("такого числа в массиве нет "); 
}
else
{
    Console.Write(matrix[indm - 1, indn - 1]);
    }