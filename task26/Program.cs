// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("введите число");
int A =Convert.ToInt32(Console.ReadLine());

int kol = 1;

while (A >= 10) 
{
    A = A / 10;
    kol = kol + 1;
}

Console.WriteLine ($"Количество цифр равно = {kol}");
