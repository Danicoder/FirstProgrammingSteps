using System;
using System.Data;

namespace FabiCal
{
    class Program
    {
        public static void LaunchAddSubMenu(int Acommule)
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
            }
        }
        //funcion para controlar el menu de sumas
        public static void LaunchAddMenu()
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                int number1 = UserInterfaceUtils.ReadInteger("Introduce el primer número");
                int number2 = UserInterfaceUtils.ReadInteger("Introduce el segundo número");
                int result = number1 + number2;
                System.Console.WriteLine("Resultado:" + result);
                UserInterface.PrintAddHeader();
                int option = UserInterface.ReadMainOption();
                if (option == 0)
                {
                    //directamete sale de la función
                    return;
                }
                else if (option == 2)
                {
                    LaunchAddSubMenu(result);
                }
            }
        }
        public static void LaunchMainMenu()
        {
            while (true)
            {
                
                UserInterface.PrintMainMenu();
                //como leemos lo que imprime por pantalla.
                int option = UserInterface.ReadMainOption();

                if (option == 0)
                {
                    return;
                }
                else if (option == -1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Has introducido algo no válido, vuelve a introducir otro nº");
                }
                else if (option < 0 || option > 7)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Has introducido algo no válido, vuelve a intertarlo");
                }
                else if (option == 1)
                {
                    LaunchAddMenu();
                }

            }
        }
        
        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
    }
}
