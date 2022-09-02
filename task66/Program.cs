// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("введите M ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите N ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
int Sum = Summa(numberN, numberM);
Console.WriteLine(Sum);

}
else
{
int Sum = Summa(numberM, numberN);
Console.WriteLine(Sum);

}

int Summa(int number1, int number2)
{
    if ((number2 - number1) <=1 ) return number1 + number2;
     return (number1 + Summa (number1 + 1, number2));
}

    