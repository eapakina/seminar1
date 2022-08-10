// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if ((number < 100) & (number > 999))
{
Console.WriteLine("число не трехзначное");}
else
{
int digit1 = number / 100;
int digit2 = number % 10;
int itog = (number - digit1*100 - digit2)/10;
Console.WriteLine(itog);
}

