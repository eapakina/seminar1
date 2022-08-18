
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] Arr = new int [12];

Random rand = new Random();

int sumP = 0;  //сумма полож
int sumN = 0;  // cумма отриц
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rand.Next(-9, 10);
if (Arr[i] > 0)
{
    sumP += Arr[i];
}
else
{sumN += Arr[i]; }//sumN = sumN+arr[i]
}

Console.WriteLine(string.Join(", ", Arr));
Console.WriteLine($"Сумма положительных = {sumP}");
Console.WriteLine($"Сумма отрицательных = {sumN}");



