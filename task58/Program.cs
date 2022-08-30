// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

 int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 1, int rightRange = 5)
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

int[,] matrix1 = FillMatrix(m,n);
int[,] matrix2 = FillMatrix(m,n);
Console.WriteLine("первая матрица");
PrintMatrix(matrix1);
Console.WriteLine("вторая матрица");
PrintMatrix(matrix2);
int[,] matrixRes = new int[m, n];

for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrixRes [i, j] = matrix1[i, j] * matrix2 [i, j];
        }
        Console.WriteLine();
    }
Console.WriteLine("итоговая матрица");
PrintMatrix(matrixRes); 