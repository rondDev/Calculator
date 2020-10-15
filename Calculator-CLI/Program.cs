using System;
using System.Text.RegularExpressions;

namespace Calculator_CLI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rond's calculator, where you can calculate whatever you desire!");
            Console.WriteLine("Valid symbols are '*', '/', '+', '-'");
            Console.Write("Enter a symbol:");
            var symbol = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.Write("Enter first number: ");
                var numOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                var numTwo = Convert.ToInt32(Console.ReadLine());
                switch (symbol)
                {
                    case "*":
                        Console.WriteLine(CalculateMultiplication(numOne, numTwo));
                        break;
                    case "/":
                        Console.WriteLine(CalculateDivision(numOne, numTwo));
                        break;
                    case "+":
                        Console.WriteLine(CalculateAddition(numOne, numTwo));
                        break;
                    case "-":
                        Console.WriteLine(CalculateSubtraction(numOne, numTwo));
                        break;
                }
                Console.Write("Click Enter to Continue");
                Console.ReadLine();
            }
        }

        private static double CalculateMultiplication(int x, int y)
        {
            double result = x * y;
            return result;
        }

        private static double CalculateDivision(int x, int y)
        {
            double result = x / y;
            return result;
        }

        private static double CalculateAddition(int x, int y)
        {
            double result = x + y;
            return result;
        }

        private static double CalculateSubtraction(int x, int y)
        {
            double result = x - y;
            return result;
        }
    }
}