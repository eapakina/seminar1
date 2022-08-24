// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("введите число");
int A =Convert.ToInt32(Console.ReadLine());

int size = (int)Math.Log2(A) + 1;
int[] array = new int [size];

for (int i = 0; i < array.Length; i++)
    {
        array [i] = A % 2;
        A = A/2;
    }
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length /2; i ++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}
ReverseArray(array);
Console.WriteLine(string.Join("", array));


