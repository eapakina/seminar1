// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("введите количество элементов в массиве");
int A =Convert.ToInt32(Console.ReadLine());

int[] Arr = new int [A];

Random rand = new Random();

int sum = 0;  
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rand.Next(100, 1000);
if ((Arr[i] % 2) == 0)
{
    sum = sum + 1;
}

}

Console.WriteLine(string.Join(", ", Arr));
Console.WriteLine($"Количество четных элементов = {sum}");


