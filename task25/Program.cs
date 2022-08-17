// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги. Решаем строго через цикл

Console.WriteLine("введите число A");
int A =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");
int B =Convert.ToInt32(Console.ReadLine());

int itog = 1;

for (int i = 1; i <= B; i++)
{
    itog = itog * A;
}

Console.WriteLine ($"число A в натуральной степени B равно {itog}");