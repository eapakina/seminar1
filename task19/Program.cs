﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("введите пятизначное число");
int x =Convert.ToInt32(Console.ReadLine());

if ((x<10000) || (x>99999))
{
Console.WriteLine ("число не пятизначное");
}
else  //поскольку аналогичные задачки по позициям чисел делала циклом, тут решила попробовать с массивом
{
char[] arr = x.ToString().ToCharArray();
if ((arr[0] == arr[4]) && (arr[1] == arr [3]))
{
    Console.WriteLine ("да");
}
else
{
    Console.WriteLine ("нет");
}
}