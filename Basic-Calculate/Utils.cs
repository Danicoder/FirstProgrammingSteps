using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class Utils
    {
        /// <summary>
        /// This function reads the option chosen by the user 
        /// and if an invalid option is intruded, the user will be warned with a -1
        /// </summary>
        /// <returns>This function returns an integer</returns>
        public static int ReadInteger()
        {
            try
            {
                int UserOption;
                UserOption = System.Convert.ToInt32(System.Console.ReadLine());
                return UserOption;
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// This function improves the visible appearance of the console with colour
        /// </summary>
        public static void PrinMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.Cyan;
            System.Console.ForegroundColor = System.ConsoleColor.Red;
        }
    }
}
