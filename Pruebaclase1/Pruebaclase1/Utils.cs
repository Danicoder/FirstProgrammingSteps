using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebaclase1
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
        //función que diga si un número es primo o no. (es primo aquel que se puede dividir por si mismo o por uno solamente)
        /*public static bool PrimeNumber(int a, int b, int value)
        {
            if ((a / (value % a) 0)
            
                return true;
           
            else
           
                return false;
            
                
        }*/

        //Serie de Fibonacii
        //aa=anterior del anterior    a=anterior
        //0,1,1,2,3,4,5,6.... puesto que desde el comiezo se empieza a sumar: 0+1=1   1+1=2   2+1=3...

        public static void Fibonacci()
        {
           int a = 0;
            int aa = 1;
            
            while (a <= 100)
            {
                System.Console.WriteLine(a + a);
                int aux = aa;
                aa = a;
                a = aux + aa;
                a++;

            }
        }
    }
}
