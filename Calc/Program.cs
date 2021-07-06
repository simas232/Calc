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
                Console.WriteLine("Simonas Marcisauskas, 2021-07-07\n\n");

                Console.WriteLine("\nChoose a Basic Arithmetic Operation to Perform:\n");

                Console.WriteLine("1 - Add (two numbers)");
                Console.WriteLine("2 - Add (multiple numbers)");
                Console.WriteLine("3 - Subtract (two numbers)");
                Console.WriteLine("4 - Subtract (multiple numbers");
                Console.WriteLine("5 - Multiply (two numbers)");
                Console.WriteLine("6 - Multiply (multiple numbers)");
                Console.WriteLine("7 - Divide (two numbers)");
                Console.WriteLine("8 - Divide (multiple numbers)\n\n");

                menuChoice = Input.AskForIntInput(0, 8,
                    "Enter Your Choice or Press 0 to Terminate the Program: ");

                string userStringInput;
                double firstNumber;
                double secondNumber;

                switch (menuChoice)
                {
                    case 0:
                        Output.PrintTextInColor("Program Terminated!", ConsoleColor.Green, true);
                        return;
                    case 1:
                        Output.PrintTextInColor("Enter The First Number: ", ConsoleColor.Green, true);
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Output.PrintTextInColor("Enter The Second Number: ", ConsoleColor.Green, true);
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Output.PrintTextInColor($"Addition Result: { Calculator.Add(firstNumber, secondNumber) }", ConsoleColor.Green, true);
                        break;
                    case 2:
                        Console.WriteLine("Enter A Set of Numbers, Separated by Whitespace Characters (e.g. \"5,5 9,4 7\": \n");
                        userStringInput = Console.ReadLine();
                        Output.PrintTextInColor($"Subtraction Result: { Calculator.Add(Input.ParseDoubleInput(userStringInput)) }", ConsoleColor.Green, true);
                        break;
                    case 3:
                        Output.PrintTextInColor("Enter The First Number: ", ConsoleColor.Green, true);
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Output.PrintTextInColor("Enter The Second Number: ", ConsoleColor.Green, true);
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Output.PrintTextInColor($"Subtraction Result: { Calculator.Subtract(firstNumber, secondNumber) }", ConsoleColor.Green, true);
                        break;
                    case 4:
                        Console.WriteLine("Enter A Set of Numbers, Separated by Whitespace Characters (e.g. \"5,5 9,4 7\": \n");
                        userStringInput = Console.ReadLine();
                        Output.PrintTextInColor($"Division Result: { Calculator.Subtract(Input.ParseDoubleInput(userStringInput)) }", ConsoleColor.Green, true);
                        break;
                    case 5:
                        Output.PrintTextInColor("Enter The First Number: ", ConsoleColor.Green, true);
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Output.PrintTextInColor("Enter The Second Number: ", ConsoleColor.Green, true);
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Output.PrintTextInColor($"Multiplication Result: { Calculator.Multiply(firstNumber, secondNumber) }", ConsoleColor.Green, true);
                        break;
                    case 6:
                        Console.WriteLine("Enter A Set of Numbers, Separated by Whitespace Characters (e.g. \"5,5 9,4 7\": \n");
                        userStringInput = Console.ReadLine();
                        Output.PrintTextInColor($"Subtraction Result: { Calculator.Multiply(Input.ParseDoubleInput(userStringInput)) }", ConsoleColor.Green, true);
                        break;
                    case 7:
                        Output.PrintTextInColor("Enter The First Number: ", ConsoleColor.Green, true);
                        firstNumber = Convert.ToDouble(Console.ReadLine());
                        Output.PrintTextInColor("Enter The Second Number: ", ConsoleColor.Green, true);
                        secondNumber = Convert.ToDouble(Console.ReadLine());
                        Output.PrintTextInColor($"Division Result: { Calculator.Divide(firstNumber, secondNumber) }", ConsoleColor.Green, true);
                        break;
                    case 8:
                        Console.WriteLine("Enter A Set of Numbers, Separated by Whitespace Characters (e.g. \"5,5 9,4 7\": \n");
                        userStringInput = Console.ReadLine();
                        Output.PrintTextInColor($"Division Result: { Calculator.Divide(Input.ParseDoubleInput(userStringInput)) }", ConsoleColor.Green, true);
                        break;
                }

                Input.WaitForSpacebar();
            } while (true);
        }   
    }
}
