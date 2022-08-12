// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("введите координату x точки А");
int xA =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату y точки А");
int yA =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату x точки B");
int xB =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату y точки В");
int yB =Convert.ToInt32(Console.ReadLine());


double res= Math.Sqrt( Math.Pow((xB-xA),2) + Math.Pow((yB-yA),2));

Console.WriteLine(res);