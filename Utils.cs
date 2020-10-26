using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo_2
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int GetMixValue(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        
        //para cuando es par.
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;

            else
                return false;
        }
        //función que devuelva por pantañña si un número es primo o no
        //este ejercicio lo vamos a separar en dos partes
        //donde ponemos una función que nos devuelva si un número es primo o no
        //el 2.3 si 4 o 1 no
        

        public static bool Isprime(int number)
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

        public static void ImprimirAsciis()
        {
            for (int i = 33; i <= 255; i++)
            {
                System.Console.Write(i);
                System.Console.Write(") es el caracter^[");
                System.Console.Write((char)i);
                System.Console.Write("[");

            }
        }


    }
}
