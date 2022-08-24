//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("введите количество чисел");
int M =Convert.ToInt32(Console.ReadLine());

int[] array = new int [M];
int kol = 0;

for (int i = 0 ; i < array.Length; i++)
{
    Console.WriteLine("введите число");
    array[i] =Convert.ToInt32(Console.ReadLine());
if (array[i] > 0)
{
    kol = kol + 1;
}
}
Console.WriteLine($"Количество чисел больше нуля  = {kol}");
Console.WriteLine($"Исходный массив {string.Join(", ", array)}");