// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("введите начальное число матрицы ");
int a = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[4, 4];
matrix[0, 0] = a;
for (int i = 1; i < 4; i++)
{
    matrix[0, i] = matrix[0, i-1] + 1;

}
for (int i = 1; i < 4; i++)
{
    matrix[i, 3] = matrix[i-1, 3] + 1;
}
for (int i = 1; i < 4; i++)
{
    matrix[3, 3-i] = matrix[3, 4-i] + 1;
}

for (int i = 1; i < 3; i++)
{
    matrix[3-i, 0] = matrix[4-i, 0] + 1;
}

for (int i = 1; i < 3; i++)
{
    matrix[1, i] = matrix[1, i-1] + 1;

}
for (int i = 2; i < 3; i++)
{
    matrix[i, 2] = matrix[i-1, 2] + 1;
}

for (int i = 2; i < 3; i++)
{
    matrix[2, 3-i] = matrix[2, 4-i] + 1;
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
PrintMatrix(matrix);