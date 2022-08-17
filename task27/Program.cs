// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("введите число");
int A =Convert.ToInt32(Console.ReadLine());

int sum = 0;
A = Math.Abs(A);
while (A > 10) 
{
    sum = sum + A % 10;
    A = A /10;
}
sum = sum + A;
Console.WriteLine ($"сумма цифр равно = {sum}");
