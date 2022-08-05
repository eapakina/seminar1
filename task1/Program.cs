// SНапишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2)
{ 
    Console.WriteLine("да");

}
else

{ 
    Console.WriteLine("нет");

}