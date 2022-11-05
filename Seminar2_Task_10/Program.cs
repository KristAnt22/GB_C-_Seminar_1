internal class Program
{
    private static void Main(string[] args)
    {
        /*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
        показывает вторую цифру этого числа.
        456 -> 5
        782 -> 8
        918 -> 1*/
        int GetTwoDigit(int number)
        {
            number = number / 10;
            return number % 10;
        }

        Console.WriteLine("Введедите трехзначное число");
        string inputString = Console.ReadLine();
        int num = int.Parse(inputString);
        if ((num > 99) & (num < 1000))
        {
            Console.WriteLine($"вторая цифра введенного числа: {GetTwoDigit(num)}");
        }
        else 
        {
            Console.WriteLine("Ошибка! Введено не корректное значение.");
        }
    }
}