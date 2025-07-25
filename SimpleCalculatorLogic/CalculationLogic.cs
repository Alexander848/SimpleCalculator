

using System;
using System.Collections.Generic;
using System.Data;

namespace SimpleCalculator.Logic
{
    public class CalculationLogic
    {
        /// <summary>
        /// Takes a string of a mathematical calculation and calculates result.
        /// </summary>
        /// <param name="input">String of mathematical calculation</param>
        /// <returns>String of calculation result or "error"</returns>
        public static String CalculateMathematicalInput(String input)
        {
            if (!CheckCalculationInput(input))
                return "error";

            try
            {
                return (new DataTable().Compute(input, null).ToString()) ?? "";
            }
            catch (Exception)
            {
                return "error";
            }
        }

        /// <summary>
        /// Checks if input consists of only these signs: [0-9],+,-,*,/,.,(,) or spaces .
        /// </summary>
        /// <param name="input">String of mathematical calculation.</param>
        /// <returns>true, if check successful, else false</returns>
        private static bool CheckCalculationInput(String input)
        {
            foreach (char sign in input)
            {
                if (char.IsDigit(sign))
                    continue;
                switch (sign)
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '.':
                    case '(':
                    case ')':
                    case ' ':
                        continue;
                    default:
                        return false;
                }
            }
            return true;
        }
    }
}
