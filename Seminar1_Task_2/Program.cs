//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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