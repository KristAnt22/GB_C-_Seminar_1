﻿
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int i= 1;
for (i = 1; i <= number; i++)
{
   if ((i % 2) == 0)
    {
       System.Console.WriteLine(i);
    }
}