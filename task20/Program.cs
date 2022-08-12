// Задача 20

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("введите координату x точки А");
int xA =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату y точки А");
int yA =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату z точки А");
int zA =Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите координату x точки B");
int xB =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату y точки В");
int yB =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату z точки B");
int zB =Convert.ToInt32(Console.ReadLine());

double res= Math.Sqrt( Math.Pow((xB-xA),2) + Math.Pow((yB-yA),2) + Math.Pow((zB-zA),2));

Console.WriteLine($"{res:f2}");