// Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
if (number > 0)
{
    index = number*(-1);}

    else 

    index = number;



while (index<=number)
{Console.Write(index);
Console.Write(", ");
index = index + 1;}