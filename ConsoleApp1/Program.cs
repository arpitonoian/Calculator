using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            bool intResult;

            Console.Write("Please enter the first integer: ");

            if (intResult = Int32.TryParse(Console.ReadLine(), out int number1) == false)
            {
                Console.WriteLine("Input is not in integer format");
                return;
            }

            Console.Write("Please enter the second integer: ");

            if (intResult = Int32.TryParse(Console.ReadLine(), out int number2) == false)
            {
                Console.WriteLine("Input is not in integer format");
                return;
            }

            Console.Write("Please enter an operand (+, -, /, *): ");

            string operand = Console.ReadLine();

            switch (operand)
            {
                case "+":
                    result = Add(number1, number2);
                    break;
                case "-":
                    result = Subtract(number1, number2);
                    break;
                case "*":
                    result = Multiply(number1, number2);
                    break;
                case "/":
                    if (Divide(number1, number2) == 0)
                    {
                        Console.Write("The second integer is zero. Devide by zero.\n");
                    }
                    else
                    {
                        result = Divide(number1, number2);
                    }
                    break;

                default:
                    Console.WriteLine("Unknown operator:");
                    break;
            }
            Console.WriteLine(number1 + operand + number2 + "=" + result);
        }

        static public double Add(double num1, double num2) => num1 + num2;

        static public double Subtract(double num1, double num2) => num1 - num2;

        static public double Multiply(double num1, double num2) => num1 * num2;

        static public double Divide(double num1, double num2)
        {
            if (num2 == 0) return 0;
            else
                return num1 / num2;

        }

    }
}
