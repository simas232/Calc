using System;

namespace Calc.Utilities
{
    public class Output
    {
        public static void PrintTextInColor(string printedMessage, ConsoleColor requiredColor, bool addNewline)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = requiredColor;
            Console.Write(printedMessage);
            if (addNewline)
            {
                Console.WriteLine("");
            }
            Console.ForegroundColor = originalColor;
        }
        public static void RemoveLastPrintedLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
        }
    }
}
