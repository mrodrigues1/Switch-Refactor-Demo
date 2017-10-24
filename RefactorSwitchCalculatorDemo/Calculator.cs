using System;
using System.Collections.Generic;

namespace RefactorSwitchDemo
{
    public interface ICalculate
    {
        double Calculate(string number, string number2);
    }

    public class Add : ICalculate
    {
        public double Calculate(string number, string number2)
        {
            return double.Parse(number) + double.Parse(number2);
        }
    }

    public class Subtraction : ICalculate
    {
        public double Calculate(string number, string number2)
        {
            return double.Parse(number) - double.Parse(number2);
        }
    }

    public class Multiply : ICalculate
    {
        public double Calculate(string number, string number2)
        {
            return double.Parse(number) * double.Parse(number2);
        }
    }


    public class Divide : ICalculate
    {
        public double Calculate(string number, string number2)
        {
            return double.Parse(number) / double.Parse(number2);
        }
    }

    public static class CalculatorFactory
    {
        private static readonly Dictionary<string, Func<ICalculate>> _calculatorMap = new Dictionary<string, Func<ICalculate>>
        {
            {"+", () => new Add()},
            {"-", () => new Subtraction()},
            {"*", () => new Multiply()},
            {"/", () => new Divide()},
        };

        public static ICalculate CreateCalculatorFromOperation(string operation)
        {
            return _calculatorMap[operation]();
        }
    }    
}