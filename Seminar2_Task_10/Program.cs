internal class Program
{
    private static void Main(string[] args)
    {
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