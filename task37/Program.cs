// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("введите количество элементов в массиве");
int N =Convert.ToInt32(Console.ReadLine());

int[] Arr = new int [N];
int[] ArrR = new int [Arr.Length/2 + Arr.Length%2];

Random rand = new Random();
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rand.Next(-10, 10);
    
}
Console.WriteLine(string.Join(", ", Arr));
   
for (int i = 0; i < ArrR.Length; i++)
{
    ArrR[i] = Arr[i] * Arr [N-i-1];
}
if (Arr.Length/2 != 0)
{
    ArrR[ArrR.Length-1] = Arr [N/2];
}
Console.WriteLine(string.Join(", ", ArrR));
