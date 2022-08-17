// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int number = new Random().Next(100,1000);

int[] myArr = new int [5];
int i = 0;
for (i =0; i <= 4; i++)
{
    myArr[i] = new Random().Next(0,2);
}

for (i=0; i <= 4; i++)
{
    Console.Write(myArr[i]);
}