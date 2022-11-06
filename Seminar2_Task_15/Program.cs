/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет   */

string Weekend(int num)
{
    if (num > 0 && num < 8)
    {
        if ((num == 7) || (num == 6))
        {
            Console.WriteLine("Выходной!");
        }
        else
        {
            Console.WriteLine("Рабочий день.");
        }
    }
    else
    {
        Console.WriteLine("Ошибка! Введите цифру от 1 до 7.");
    }
    return ""; 
}

Console.WriteLine("Введите цифру, обозначающую день недели");
String inputString = Console.ReadLine()!;   
int number = int.Parse(inputString)!;  
Console.WriteLine(Weekend(number));
