using System;

namespace Calc.Utilities
{
    public class Input
    {
        public static int AskForIntInput(int minValue, int maxValue, string recurringLine)
        {
            int inputValue;
            string warningMessage = "Invalid Choice! Enter a Number between " + minValue + " and " + maxValue + ".";
            Output.PrintTextInColor(recurringLine, ConsoleColor.Green, false);

            while (!int.TryParse(Console.ReadLine(), out inputValue) || inputValue < minValue || inputValue > maxValue)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                Output.PrintTextInColor(warningMessage, ConsoleColor.Red, true);
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                Output.PrintTextInColor(recurringLine, ConsoleColor.Green, false);
            }
            Output.RemoveLastPrintedLine();
            Output.RemoveLastPrintedLine();
            Console.WriteLine("");
            return inputValue;
        }
        public static double AskForDoubleInput(string recurringLine)
        {
            double inputValue;
            string warningMessage = "Invalid Choice! Enter a Real Number.";
            Output.PrintTextInColor(recurringLine, ConsoleColor.Green, false);

            while (!double.TryParse(Console.ReadLine(), out inputValue))
            {
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                Output.PrintTextInColor(warningMessage, ConsoleColor.Red, true);
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                Output.PrintTextInColor(recurringLine, ConsoleColor.Green, false);
            }
            Output.RemoveLastPrintedLine();
            Output.RemoveLastPrintedLine();
            Console.WriteLine("");
            return inputValue;
        }
        public static double GetFirstValue(bool inheritCalculation, double inheritedResult)
        {
            double firstValue = inheritCalculation ? inheritedResult : Input.AskForDoubleInput("Enter a First Number: ");
            return firstValue;
        }
    }
}
