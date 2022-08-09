// напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру

int number = new Random().Next(100,1000);
int digit1 = number / 100;
int digit2 = number % 10;
Console.WriteLine(number);
Console.WriteLine(digit1);
Console.WriteLine(digit2);
int itog = digit1*10 + digit2;
Console.WriteLine(itog);
