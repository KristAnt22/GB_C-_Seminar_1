/*Дополнительная Задача 9
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да   */

string Maltiplicity(int num)
{
    if ((num % 7 == 0) && (num % 23 == 0))
    {
        Console.WriteLine($"Число {num} кратно и 7 и 23 одновременно");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
    return ""; 
}

Console.WriteLine("Введите число");
String inputString = Console.ReadLine()!;   
int number = int.Parse(inputString)!;  
Console.WriteLine(Maltiplicity(number));

