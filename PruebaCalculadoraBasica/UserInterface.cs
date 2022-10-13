using System;
using System.Collections.Generic;
using System.Text;

namespace FabiCal
{
    class UserInterface
    {
       /// <summary>
       //escribe menu de sumas
       /// </summary>
        public static void PrintAddHeader()
        {
            System.Console.WriteLine(" suma");
            System.Console.WriteLine("----------------");
        }
        public static void PrintAdsubmenu()
        {
            System.Console.WriteLine("0) salir");
            System.Console.WriteLine("1) reiniciar");
            System.Console.WriteLine("2) Acumular otro");
        }
        //leer por pantalla el entero
        public static int ReadMainOption()
        {
            try
            {
                string option = System.Console.ReadLine();
                int result = System.Convert.ToInt32(option);
                return result;
            }
            catch (System.Exception e)
            {
                return -1;                //rolback con control z
                                            //el -1 simboliza que no ha puesto un valor establecido en nuestro programa
            }
            /*finally
            {

            ¨{*/       
            
        }

        public static void PrintMainMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.Blue;
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("FabiCal");
            System.Console.ResetColor();
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine(" 1) Realizar suma");
            System.Console.WriteLine(" 2) Realizar resta");
            System.Console.WriteLine(" 3) Realizar multiplicación");
            System.Console.WriteLine(" 4) Realizar división");
            System.Console.WriteLine(" 5) Realizar raíces");
            System.Console.WriteLine(" 6) mostrar Serie de Fibonacci");
            System.Console.WriteLine(" 7) calcular sumatorio");
            System.Console.WriteLine(" 0) Salir de la aplicación");
        }
         

            
    }
}
