

using System;
using System.Collections.Generic;

namespace SimpleCalculatorApplication
{
    public class CalculationLogic
    {
        /// <summary>
        /// Creates tokens of mathematical calculation string.
        /// Numbers and dots are kept together, +,-,*,/,(,) get their own token.
        /// </summary>
        /// <param name="input">String of mathematical calculation</param>
        /// <returns>List of tokens</returns>
        public static List<String> TokenizeCalculation(String input)
        {
            String stringBuffer = "";
            List<String> tokens = new List<String>();

            foreach (char sign in input)
            {
                if (sign.Equals('+') || sign.Equals('-') || sign.Equals('*') ||
                    sign.Equals('/') || sign.Equals('(') || sign.Equals(')'))
                {
                    if (stringBuffer.Length > 0)
                    {
                        tokens.Add(stringBuffer);
                        stringBuffer = "";
                    }
                    tokens.Add(sign.ToString());
                }
                else
                {
                    stringBuffer += sign;
                }
            }

            if (stringBuffer.Length > 0)
                tokens.Add(stringBuffer);

            return tokens;
        }

        public static String CalculateTokensRecursively(List<String> tokens)
        {
            try
            {

            }
            catch (Exception)
            {
                return "error";
            }

            return "test";
        }
    }
}
