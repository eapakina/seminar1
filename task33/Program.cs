// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет"



Console.WriteLine("введите количество элементов в массиве");
int A =Convert.ToInt32(Console.ReadLine());

int[] Arr = new int [A];

Random rand = new Random();
Console.WriteLine("введите число");
int number =Convert.ToInt32(Console.ReadLine());
bool res = false;

for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rand.Next(-9, 10);
    if (Arr [i] == number)
    {
        res = true;
    }
    
}
Console.WriteLine(string.Join(", ", Arr));


if (res == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine ("нет");
}