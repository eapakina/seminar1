// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("введите координату x");
int x =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату y");
int y =Convert.ToInt32(Console.ReadLine());

if (x > 0 && y >0 )
{
    Console.WriteLine("точка находится в первой координатной четверти");
}
else if (x < 0 && y > 0 )
{
    Console.WriteLine("точка находится во второй координатной четверти");
}
else if (x  < 0 && y < 0 )
{
    Console.WriteLine("точка находится в третьей координатной четверти");
}
else if (x > 0 && y < 0 )
{
    Console.WriteLine("точка находится в четвертой координатной четверти");
}
else 
{
    Console.WriteLine("не можем определить");
}