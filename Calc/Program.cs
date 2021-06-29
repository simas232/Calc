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

                Console.WriteLine("Enter A Set of Numbers, Separated by Whitespace Characters (e.g. \"5,5 9,4 7\": \n");
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
                        Output.PrintTextInColor("Program Terminated! (Why Did You Enter These Numbers Anyway?)", ConsoleColor.Green, true);
                        return;
                    case 1:
                        Output.PrintTextInColor($"Addition Result: { Calculator.Add(Input.ParseDoubleInput(userInput)) }", ConsoleColor.Green, true);
                        break;
                    case 2:
                        Output.PrintTextInColor($"Subtraction Result: { Calculator.Subtract(Input.ParseDoubleInput(userInput)) }", ConsoleColor.Green, true);
                        break;
                    case 3:
                        Output.PrintTextInColor($"Multiplication Result: { Calculator.Multiply(Input.ParseDoubleInput(userInput)) }", ConsoleColor.Green, true);
                        break;
                    case 4:
                        Output.PrintTextInColor($"Division Result: { Calculator.Divide(Input.ParseDoubleInput(userInput)) }", ConsoleColor.Green, true);
                        break;
                }

                Input.WaitForSpacebar();
            } while (true);
        }   
    }
}
