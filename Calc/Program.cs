using System;
using Calc.Utilities;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Program {0} ***", nameof(Calc));
                Console.WriteLine("Simonas Marcisauskas, 2021-06-28\n\n");

                Console.WriteLine("Enter A Set of Numbers, Separated by Commas: \n");
                string userInput = Console.ReadLine();

                Console.WriteLine("\nChoose a Basic Arithmetic Operation to Perform:\n");

                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Subtract");
                Console.WriteLine("3 - Multiply");
                Console.WriteLine("4 - Divide\n\n");

                menuChoice = Input.AskForIntInput(0, 4,
                    "Enter Your Choice or Press 0 to Terminate the Program: ");

                switch (menuChoice)
                {
                    case 0:
                        Output.PrintTextInColor("Program Terminated!", ConsoleColor.Green, true);
                        return;
                    case 1:
                        Output.PrintTextInColor($"Addition Result: { Add(Input.ParseDoubleInput(userInput)) }", ConsoleColor.Green, true);
                        break;
                    case 2:
                        Output.PrintTextInColor($"Subtraction Result: { Subtract(Input.ParseDoubleInput(userInput)) }", ConsoleColor.Green, true);
                        break;
                    case 3:
                        Output.PrintTextInColor($"Multiplication Result: { Multiply(Input.ParseDoubleInput(userInput)) }", ConsoleColor.Green, true);
                        break;
                    case 4:
                        Output.PrintTextInColor($"Division Result: { Divide(Input.ParseDoubleInput(userInput)) }", ConsoleColor.Green, true);
                        break;
                }

                Input.WaitForSpacebar();
            } while (true);
        }

        // math functions
        static double Add(double[] values)
        {
            double result = double.NaN;
            if (values.Length > 1)
            {
                result = values[0];
                for (int index = 1; index < values.Length; index++)
                {
                    result += values[index];
                }
            }

            return result;
        }
        static double Subtract(double[] values)
        {
            double result = double.NaN;
            if (values.Length > 1)
            {
                result = values[0];
                for (int index = 1; index < values.Length; index++)
                {
                    result -= values[index];
                }
            }

            return result;
        }
        static double Multiply(double[] values)
        {
            double result = double.NaN;
            if (values.Length > 1)
            {
                result = values[0];
                for (int index = 1; index < values.Length; index++)
                {
                    result *= values[index];
                }
            }

            return result;
        }
        static double Divide(double[] values)
        {
            double result = double.NaN;
            if (values.Length > 1)
            {
                result = values[0];
                for (int index = 1; index < values.Length; index++)
                {
                    if (values[index] != 0)
                    {
                        result /= values[index];
                    }
                    else
                    {
                        Output.PrintTextInColor("Division by Zero Detected!", ConsoleColor.Red, true);
                        return double.NaN;
                    }
                }
            }
            return result;
        }
    }
}
