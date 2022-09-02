﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("введите M ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите N ");
int numberN = Convert.ToInt32(Console.ReadLine());
PrintNumbersNToM(numberM, numberN);

void PrintNumbersNToM(int m, int n)
{
    if (n < m) return;
    Console.Write(m + " ");
    PrintNumbersNToM(m+1, n);
    }
