using System;
using Calc.Utilities;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            bool inheritCalculation = false;
            double inheritedResult = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Program {0} ***", nameof(Calc));
                Console.WriteLine("Simonas Marcisauskas, 2021-06-14\n\n");

                Console.WriteLine("Choose a Basic Arithmetic Operation to Perform:\n");

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
                        inheritedResult = Add(GetFirstValue(inheritCalculation, inheritedResult), Input.AskForDoubleInput("Enter a Second Number: "));
                        break;
                    case 2:
                        inheritedResult = Subtract(GetFirstValue(inheritCalculation, inheritedResult), Input.AskForDoubleInput("Enter a Second Number: "));
                        break;
                    case 3:
                        inheritedResult = Multiply(GetFirstValue(inheritCalculation, inheritedResult), Input.AskForDoubleInput("Enter a Second Number: "));
                        break;
                    case 4:
                        inheritedResult = Divide(GetFirstValue(inheritCalculation, inheritedResult), Input.AskForDoubleInput("Enter a Second Number: "));
                        break;
                }
                Output.PrintTextInColor($"\nPress <Enter> If You Want to Use {inheritedResult} as the First Value for Further Calculations.", ConsoleColor.Green, true);
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    inheritCalculation = true;
                } else
                {
                    inheritCalculation = false;
                    inheritedResult = 0;
                }
            } while (true);

            static double Add(double firstValue, double secondValue)
            {
                double result = firstValue + secondValue;
                Output.PrintTextInColor($"{firstValue} + {secondValue} = {result}!", ConsoleColor.Green, true);
                return result;
            }
            static double Subtract(double firstValue, double secondValue)
            {
                double result = firstValue - secondValue;
                Output.PrintTextInColor($"{firstValue} - {secondValue} = {result}!", ConsoleColor.Green, true);
                return result;
            }
            static double Multiply(double firstValue, double secondValue)
            {
                double result = firstValue * secondValue;
                Output.PrintTextInColor($"{firstValue} * {secondValue} = {result}!", ConsoleColor.Green, true);
                return result;
            }
            static double Divide(double firstValue, double secondValue)
            {
                if (secondValue != 0)
                {
                    double result = firstValue / secondValue;
                    Output.PrintTextInColor($"{firstValue} / {secondValue} = {result}!", ConsoleColor.Green, true);
                    return result;
                }
                else
                {
                    Output.PrintTextInColor("Division by Zero Detected! The Result Is Therefore Set to 0.", ConsoleColor.Red, true);
                    return 0;
                }
            }
            static double GetFirstValue(bool inheritCalculation, double inheritedResult)
            {
                double firstValue = inheritCalculation ? inheritedResult : Input.AskForDoubleInput("Enter a First Number: ");
                return firstValue;
            }
        }
    }
}
