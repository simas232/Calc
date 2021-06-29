using System;
using Calc.Utilities;

namespace Calc
{
    public class Calculator
    {
        public static double Add(double[] values)
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
        public static double Subtract(double[] values)
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
        public static double Multiply(double[] values)
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
        public static double Divide(double[] values)
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
