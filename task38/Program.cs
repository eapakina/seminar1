// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] Arr = {1.2, 3, 4, -6, 0, 6.7, 19.3};
Console.WriteLine(string.Join(", ", Arr));
double max = Arr[0];
double min = Arr[0];
double res = Arr[0];


 for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] > max)
    {
        max =  Arr [i];
    }
    if (Arr[i] < min)
    {
        min =  Arr [i];
    }
}
   
Console.WriteLine($"Разница максимального и минимального значения  = {(max - min)}");

