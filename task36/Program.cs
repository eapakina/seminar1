// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("введите количество элементов в массиве");
int A =Convert.ToInt32(Console.ReadLine());

int[] Arr = new int [A];
int sum = 0;

Random rand = new Random();
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rand.Next(-10, 10);
    if ((i % 2) != 0 )
    {
        sum = sum + Arr [i];
    }
}
   
Console.WriteLine(string.Join(", ", Arr));
Console.WriteLine($"Cумма элементов на нечетных позициях = {sum}");


