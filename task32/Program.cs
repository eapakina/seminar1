// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("введите количество элементов в массиве");
int A =Convert.ToInt32(Console.ReadLine());

int[] Arr = new int [A];

Random rand = new Random();

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rand.Next(-99, 100);
}
Console.WriteLine(string.Join(", ", Arr));

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = Arr[i] * (-1);
}
Console.WriteLine(string.Join(", ", Arr));


