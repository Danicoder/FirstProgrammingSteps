using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ejemplo_2
{
    class ejercicioswhile
    {
        //ejercicio: Hacer una función que imprima por pantalla los números del 0 al 99, salvo que ponga imprime por pantalla "console.writeline" (es solo para aplicacion de consola o para mensajes de debood)
        // recordar el MVC (en relacion a console.writeline)
        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                // contador = contador + 1;
                // contador += 1;
                contador++;
            }

        }
        //función que imprima por pantalla todos los números pares desde el 0 hasta n

        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(1);
                i++;
            }
           
        }
        
        public static void Ejercicioserie1()
        {
            int i = 0;
                        
            while (i < 100)
            {
                System.Console.WriteLine(i);
                i++;

            }
        }

        
        //al multiplicar la 1*2 sale el multiplo de 2
        public static void Ejercicioserie2()
        {
            int i = 0;

            while (i < 100)
            {
                System.Console.WriteLine(i * 2);

                i++;
            }
        }
        public static void Ejrcicioserie3()
         {
            int i = 0;

            while (i < 100)
            {
                System.Console.WriteLine((i * 3) + 1);

                i++;
            }
        }

        public static void Ejercicioserie4()
        {
            int i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(i * i);
                i++;
            }
        }
        public static void Ejercicioserie5()
        {
            int i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(i * i);
                i++;
            }
        }




    }
}
