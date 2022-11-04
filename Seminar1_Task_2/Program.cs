//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 1е число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2е число");
int number2 = int.Parse(Console.ReadLine()!);
if(number1<number2)
{
    System.Console.WriteLine($"{number1}-меньшее, {number2}- большее");
}
else
{
if(number1 == number2)
    {
        System.Console.WriteLine($"Числа равны,{number1}={number2}");
    }
    else
    {
        System.Console.WriteLine($"{number2}-меньшее, {number1}- большее");
    }
}