// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вводим массив через консоль

int[] myArr = new int [8];
int i;
for (i =0; i <= 7; i++)
{
    Console.WriteLine($"введите {i} элемент массива");
    myArr[i] =Convert.ToInt32(Console.ReadLine());

}


Console.WriteLine(string.Join(", ", myArr));