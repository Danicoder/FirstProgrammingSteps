
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Pruebaclase1
{
    class Exercisesexams
    {
        //hacer una función que reciba dos números enteros y devuelva la suma de los dos
        public static int ExercisePlus(int n1, int n2)
        {
            return n1 + n2;
        }


        //funcion que se le den dos reales y que devuelva la resta de esos dos reales
        public static double SubtractionReal(double n1, double n2)
        {
            return n1 - n2;
        }
        //hacer dos funciones que reciba dos reales cada uno de ellas, una que devuelva el mayor de los dos reales y la otra el menos de los dos reales
        public static void RetourReal1()
        {
            System.Console.Write("escribe un número:   ");
            double option2 = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("escribe el otro número:   ");
            double option1 = System.Convert.ToDouble(System.Console.ReadLine());

            if (option1 >= option2)
            {
                System.Console.WriteLine("el nº mayor de los dos reales es:  " + option1);
            }
            else
            {
                System.Console.WriteLine(" el nº " + option2 + " es mayor que " + option1) ;
            }
        }
        public static void RetournReal2()
        {
            System.Console.Write("escribe un número:   ");
            double option2 = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("escribe el otro número:   ");
            double option1 = System.Convert.ToDouble(System.Console.ReadLine());

            if (option1 <= option2)
            {
                System.Console.WriteLine("el nº menor de ambos reales es:  " + option1);
            }
            else
            {
                System.Console.WriteLine(" el nº " + option2 + " es menor que " + option1);
            }
        }
        //hacer una funcion que se le pasen tres enteros y que devuelva el mayor de los tres
        public static int Retournint(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b > c)
                    return b;
                else
                    return c;
            }
        }

        //funcion que reciba dos enteros y devuelva -1 sí el primero es menor que el segundo,
        //1 sí el segundo es menor que el primero y 0 si los dos nº son iguales.
        public static int Receiveint(int a, int b)
        {
            if (a < b)
                return -1;
            if (a > b)
                return 1;
            return 0;
        }
        //funcion que reciba un código de error y muestre por pantalla los siguiente: "error grave" si el error es 0
        //error moderado si el erroe es 1, error leve si el error es 2, error desconocido en cualquier otro caso.
        public static void PrintError(int code)
        {
            switch (code)
            {
            case 0:
                    System.Console.WriteLine("error grave");
                    break;
                case1:
                    System.Console.WriteLine("error medio");
                case2:
                    System.Console.WriteLine("error leve");
            default:
                    System.Console.WriteLine("error desconocido");
            break;
            }
        }

        //funcion que reciba un nº y en función de ese nº que escibra la siguiente serie: 0.3.6.9.12.....
        public static void PrintSerie1(int n)
        {
            int i = 0;
            while (i <= n)
            {
                System.Console.WriteLine(i+"La siguiente serie es:");
                i += 3;
            }
        }
        //funcion que reciba un nº entero e imprima todos los nº desde el cero hasta ese nº (utilizar for)
        public static void PrintNumberRecibe(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                System.Console.WriteLine(i+",");
            }
        }
        ////funcion que reciba un nº entero e imprima (0.1.2.3.4) y seis (0.1.2.3.4.5.6)
        public static void PrintSerie2(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                System.Console.Write(i);
                    if (i < n)
                {
                    System.Console.Write(",");
                }
                        
            }
        }
        //función que devuelva el mayor de seis enteros, esa función debe ocupr una línea
        /*public static int RetournInt(int a, int b, int c, int d, int e, int f)
        {
            int mayor1=mayor3(a,b,c);
        }*/
        //hacer uan función que se le pase un entero e imprima tantos astericos como ese entero que se le pasa
        //ejemplo: asteriscos(3)***
        //asterisco(5)*****
        public static void PrintAsterisk(int n)
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("*");
            }
        }
            //hacer uan función que se le pase un entero e imprima asterisco(3)*+*+;asterisco(5)*+*+*;asterisco(/a)=*+*+*+*+*+
            /*public static void PrintAsteriskAdd(int n)
            {
                for(int i=0; i < n; i++)
                {
                    if (Utils.IsEven(i))
                    System.Console.WriteLine("*+");
                }
            }*/
            //hacer uan función que se le pase un entero e imprima asterisco(3)*+-;asterisco(5)*+-/*;asterisco(/a)=*+-/*+*-/*+
            //el resto se represetna con: %
            /*public static void PrintAsteriskAddMinus(int n)
            {
                int resto = i % 4;
                for (resto; i < n; i++)
                {
                    switch (resto)
                    {
                        case 0:
                            System.Console.WriteLine("*");
                            break;
                        case 1:
                            System.Console.WriteLine("+");
                            break;
                    }
                }

            }*/
            //hacer una funcion que pida un nº y en función de ese nº que imprima: figura (3) ***
           //;***;*** figura4=*****4veces con espacio la c es de la columna y la f de la fila
           public static void PrintOnlyAsterisk(int n)
            {
                for (int f=0;f<n;f++)
                {
                    for (int c = 0; c < n; c++)
                    System.Console.Write("*");
                }
            System.Console.WriteLine();
            }
        //hacer una funcion que pida un nº y en función de ese nº que imprima: ***;+++;***
        public static void PrintOtherAsteriskPlus(int n)
        {
            for(int f=0;f<n;f++)
            {
                for(int c=0;c<n;c++)
                {
                    if ((f%2)==0)
                    {
                        System.Console.Write("*");
                        else
                        
                            System.Console.Write("+");
                        
                    }
                }
            }
        }
    }
}
