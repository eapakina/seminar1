// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("введите число A");
int A =Convert.ToInt32(Console.ReadLine());

int sum = 1;

for (int i = 1; i <= A; i++)
{
    sum = sum * i;
}

Console.WriteLine ($"Произведение чисел от 1 до А = {sum}");