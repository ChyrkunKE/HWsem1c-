﻿//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine ("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(number1>number2)
{
    max = number1;
}
else
{
    max = number2;
}
if (number3>max)
{
   Console.WriteLine($"Максимальное число {number3}"); 
}
else
{
    Console.WriteLine($"Максимальное число {max}");
}