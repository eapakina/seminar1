// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int ostatok = number1 % number2;



Console.WriteLine(ostatok);

if (ostatok == 0)
{
    Console.WriteLine("число 1 кратно числу 2");}
else
{
        Console.Write("число 1 некратно числу 2,остаток ");
        Console.Write(ostatok);}


