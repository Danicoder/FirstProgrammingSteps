using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class ModelConsole
    {
        /// <summary>
        /// This function performs the calculation of a high power to two.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>This function returns a decimal number</returns>
        public static double LaunchPower2(int number)
        {
            if (number > 0 || number == 0)
            {
                double Constant = 1.0;
                for (int i = 0; i < number; i++)
                    Constant *= 2;
                return Constant;
            }
            else
            {
                double result = 1.0;
                for (int i = 0; i > number; i--)
                    result *= 2;
                return (1 / result);
            }
        }
        /// <summary>
        /// This function calculates the sum of a number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>This function returns a integer</returns>
        public static int GiveSumatory(int number)
        {

                int result = 0;
                for (int j = 0; number > j; j++)
                {
                    result += j;
                }
                return result;
        }
        /// <summary>
        /// This function calculates the factorial of a number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>This function returns a integer</returns>
        public static int LaunchFactorialNumber(int number)
        {
            if (number < 0)
                number *= -1;
            if (number == 0)
                return 1;
            int factorial = 1;
            while (number > 1)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
        /// <summary>
        /// This function calculates whether a number is prime or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns>This function returns a true or false value</returns>
        public static bool LaunchIsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
        /// <summary>
        /// This function calculates the successive series of Fibinacci
        /// </summary>
        /// <param name="number"></param>
        /// <returns>This function returns a string of characters</returns>
        public static string LaunchFibonacci(int number)
        {
            int number1 = 1;
            int number2 = 0;
            int j = 2;
            string result = "";
            result = result + "" + number2;
            result = result + "" + number1;

            while (number <= j)
            {
                result = result + "" + (number1 + number2);
                int aux = number2;
                number2 = number1;
                number1 = aux + number2;
                j ++;
            }
            return result;
        }
    }
}

