// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Нет чисел");}

int index = 2;

if (number == 2) 
{ Console.WriteLine ("2");}
else
{while (index <= number)
{

Console.Write(index);
Console.Write(" ,");
index = index + 2;}}

