// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] array = {1, 3,4,5,4};
int [] newarray = new int [5];

for (int i = 0; i < array.Length; i++)
{
    newarray[i]= array[i];
}

Console.WriteLine($"Исходный массив {string.Join(", ", array)}");
Console.WriteLine($"Копия массив {string.Join(", ", newarray)}");
