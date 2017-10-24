using System;

namespace RefactorSwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Basic Calculator Switch");

            Console.WriteLine("To use the calculator, first inform the two numbers and the operation");

            Console.WriteLine("First number:");

            var number = Console.ReadLine();

            Console.WriteLine("Second number:");

            var number2 = Console.ReadLine();

            Console.WriteLine("Operation: (+, -, *, /)");

            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Add(number, number2);
                    break;
                case "-":
                    Subtraction(number, number2);
                    break;
                case "*":
                    Multiply(number, number2);
                    break;
                case "/":
                    Divide(number, number2);
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        private static void Add(string number, string number2)
        {
            var result = double.Parse(number) + double.Parse(number2);

            Console.WriteLine($"Result: {result}");
        }

        private static void Subtraction(string number, string number2)
        {
            var result = double.Parse(number) - double.Parse(number2);

            Console.WriteLine($"Result: {result}");
        }

        private static void Multiply(string number, string number2)
        {
            var result = double.Parse(number) * double.Parse(number2);

            Console.WriteLine($"Result: {result}");
        }

        private static void Divide(string number, string number2)
        {
            var result = double.Parse(number) / double.Parse(number2);

            Console.WriteLine($"Result: {result}");
        }
    }
}