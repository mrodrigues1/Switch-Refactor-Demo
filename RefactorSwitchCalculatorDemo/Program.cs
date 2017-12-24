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

            var calculator = CalculatorFactory.CreateCalculator(operation);
            double result = calculator.Calculate(number, number2);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
    }
}