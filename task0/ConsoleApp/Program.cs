using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Обчислення суми двох чисел.");
        Console.WriteLine("Введіть перше число:");
        string input1 = Console.ReadLine();
        double number1;

        while (!double.TryParse(input1, out number1))
        {
            Console.WriteLine("Неправильний формат числа. Спробуйте ще раз:");
            input1 = Console.ReadLine();
        }

        Console.WriteLine("Введіть друге число:");
        string input2 = Console.ReadLine();
        double number2;

        while (!double.TryParse(input2, out number2))
        {
            Console.WriteLine("Неправильний формат числа. Спробуйте ще раз:");
            input2 = Console.ReadLine();
        }
        double sum = number1 + number2;
        Console.WriteLine($"Сума чисел {number1} та {number2} дорівнює {sum}.");
    }
}