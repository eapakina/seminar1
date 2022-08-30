// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("введите размерность");
int n = Convert.ToInt32(Console.ReadLine()); //для упрощения делаем кубический массив с равными сторонами
if (n*n*n < 100)
{
    int[,,] matrix = new int[n, n, n];

int[] array = new int[n *n *n]; //формируем массив случайных неповторяющихся чисел
Random rnd = new Random();
for  (int i =0; i < n * n * n; i++)
        {
        array[i] = rnd.Next(10, 100);
        for  (int j =0; j < i; j++)
           {if (array[i] == array[j])
           {array[i] = rnd.Next(10, 100);
           j = 0; }}}

// Console.WriteLine(string.Join(", ", array));

int count = 0;
for  (int i =0; i < n ; i++)
        {
             for  (int j =0; j < n ; j++)
           {
                for  (int k =0; k < n  ; k++)
                   {
                    //  Console.Write($"count = {count} , array[count] = {array[count]}");
    Console.WriteLine();
                  matrix[i, j, k] = array[count];
                  count = count + 1;
                      }

           }
           
        }

 for  (int i =0; i < n; i++)
        {
            // Console.Write(i);
             for  (int j =0; j < n; j++)
           {
                        // Console.Write(j);

                for  (int k =0; k < n; k++)
                   {
                                            // Console.Write(k);

            Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
                      }
                      Console.WriteLine();
           }
        }     

}
else
{
    Console.WriteLine("неверно задано значение");
}