using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue, result;
                string action;

                NumberFormatInfo numb = new NumberFormatInfo() { NumberDecimalSeparator = "," };

                try
                {

                    Console.WriteLine(" Введите первое число");
                    firstValue = double.Parse(Console.ReadLine(), numb);

                    Console.WriteLine("Введите второе число");
                    secondValue = double.Parse(Console.ReadLine(), numb);

                }
                catch (Exception)
                {
                    Console.WriteLine("Введите число вместо строки!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите оперцаию: '+' '-' '*' '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        result = firstValue + secondValue;
                        Console.WriteLine("Выш результат = " + result);
                        break;
                    case "-":
                        result = firstValue - secondValue;
                        Console.WriteLine("Выш результат = " + result);
                        break;
                    case "*":
                        result = firstValue * secondValue;
                        Console.WriteLine("Выш результат = " + result);
                        break;
                    case "/":
                        result = firstValue / secondValue;
                        Console.WriteLine("Выш результат = " + result);
                        break;
                    default:
                        Console.WriteLine("Выбрана не верная операция!");
                        break;
                }

                Console.WriteLine("Для выхода нажмите 'Esc' для продолжения 'Enter'");
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }
    }
}
