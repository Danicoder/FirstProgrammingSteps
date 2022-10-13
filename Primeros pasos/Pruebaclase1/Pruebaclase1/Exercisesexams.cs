
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
        //hacer dos funciones que reciba dos reales cada uno de ellas, una que devuelva el mayor de los dos reales y la otra el menor de los dos reales
        public static int IsGreater(int a, int b)//mayor de los dos reales
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static int IsMinor(int a, int b)//menor de los dos reales
        {
            if (a > b)
                return b;
            else
                return a;
        }
        
        //hacer una funcion que se le pasen tres enteros y que devuelva el mayor de los tres
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int IsGreatherthan3(int a, int b, int c)
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
        //función que devuelva el mayor de seis enteros
        public static int IsGreaterThan6(int a, int b, int c, int d, int e, int f)
        {
            return IsGreater(IsGreatherthan3(a, b, c), IsGreatherthan3(d, e, f));
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
                case 1:
                    System.Console.WriteLine("error medio");
                    break;
                case 2:
                    System.Console.WriteLine("error leve");
                    break;
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
                System.Console.WriteLine(n);
                n += 3;
            }
        }
        //funcion que reciba un nº entero e imprima todos los nº desde el cero hasta ese nº (utilizar for)
        public static void PrintNumberRecibe(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                System.Console.Write(i + ",");
            }
        }
        //funcion que reciba un nº entero e imprima (0.1.2.3.4) o seis (0.1.2.3.4.5.6)
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

        //hacer uan función que se le pase un entero e imprima tantos astericos como ese entero que se le pasa
        //ejemplo: asteriscos(3)***
        //asterisco(5)*****
        public static void PrintAsterisk(int n)
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("*");
            }
        }
        //hacer uan función que se le pase un entero e imprima asterisco(3)*+*;asterisco(5)*+*+*;asterisco(/a)=*+*+*+*+*+
        public static void PrintAsteriskPlusSum(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (Utils.IsEven(i)) //lo mismo que escribir if((i%2)==0)para indicar qeu si es par entra en el bucle
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }
        }
        //función que imprima +*+*... en columnas y en filas
        public static void AsteriskSum(int n)
        {
            int f;
            for (f = 0; f < n; f++)
            {
                int c;
                for (c = 0; c < n; c++)
                {
                    int flag = c + f;

                    if ((flag % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }
        //hacer uan función que se le pase un entero e imprima (/n)=*+-/*+*-/*+
        public static void PrintAsteriskAddMinus(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                switch (i % 4)//el resto se represetna con: %
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }
            }

        }
        //hacer una funcion que pida un nº y en función de ese nº que imprima: figura (3) ***
        //veces con espacios de por medio
        public static void PrintOnlyAsterisk(int n)
        {
            for (int f = 0; f < n; f++)// f de fila
            {
                for (int c = 0; c < n; c++)// c de columna
                    System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        //hacer una funcion que si paso un tres imprima 3x3 con asteriscos 
        public static void SquareShape(int n)
        {
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((f % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }
        //funcion que imprima con asteriscos la forma de una escalera (lader) inversa
        public static void BackStairs(int n)
        {
            int f;
            for (f = 0; f < n; f++)
            {
                int nSpace = n - (f + 1);
                int nAsterisk = f + 1;
                int c;
                for (c = 0; c < nSpace; c++)
                    System.Console.Write(" ");
                for (c = 0; c < nAsterisk; c++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }
        }
        //imprimir por pantalla la forma de una pirámide
        public static void Pyramid(int n)
        {
            int f;
            for (f = 0; f < n; f++)
            {
                int nAsterisk1 = n - f - 1;
                int nAsterisk2 = f * 2;
                int c;

                for (c = 0; c < nAsterisk1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");


                for (c = 0; c < nAsterisk2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                System.Console.WriteLine();
            }
        }
        //igual que el ejercicio anterior pero escrito de manera distinta
        public static void Pyramid2(int n)
        {
            int f;
            for (f = 0; f < n; f++)
            {
                int nAsterisk1 = n - f - 1;
                int nAsterisk2 = (f * 2) - 1;//MaxValue (0,2*f -1) para que cuando f sea 0, la solucuón no sea...
                int c;

                for (c = 0; c < nAsterisk1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                for (c = 0; c < nAsterisk2; c++)
                    System.Console.Write(" ");
                if (f != 0)
                    System.Console.Write("*");

                System.Console.WriteLine();
            }
        }
        //hacer la pirámide alreves
        public static void PyramidBack(int n)
        {
            int f;
            for (f = 0; f < n; f++)
            {
                int nAsterisk1 = f;
                int nAsterisk2 = (n - f - 1) * 2;
                int c;

                for (c = 0; c < nAsterisk1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                for (c = 0; c < nAsterisk2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                System.Console.WriteLine(" ");
            }
        }//hacer un ROMBO (rhombus)
        public static void Romrhombusbo(int n)
        {
            Pyramid(n);
            PyramidBack(n);
        }
        public static void AmericanFlag()
        {
            int f;

            for (f = 0; f < 10; f++)
            {
                int c;
                for (c = 0; c < 15; c++)
                {
                    int f2 = f / 2;

                    if (0 <= c && c <= 5 && 0 <= f && f <= 2)
                    {
                        int flag = c + f;
                        if ((flag % 2) == 0)// o lo hago invocando: Utils.IsEven(flag)
                            System.Console.Write("+");
                        else
                            System.Console.Write(" ");
                    }
                    else if ((f2 % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        public static void JapaneseFlag()
        {
            double f;
            double c;
            for (f = 0; f < 19; f++)
            {
                
                for (c = 0; c < 74; c++)
                {
                    if (c == 0 || c == 73 || f == 0 || f == 18)
                        System.Console.Write("*");
                    else if (Geometric.CalculateDistance2D(37, 10, c, f) < 5.0)
                        System.Console.Write("0");
                    else
                        System.Console.Write(" ");

                    System.Console.WriteLine();
                }
            }
        }
        //hacer uan función que devuelva el sumatorio de un número por ejemplo de 6=1+2+3
        //se cuantas veces voy a repetir la secuencia, por tanto pongo for
        public static int RetournNumber (int n)
        {
            int result = n;
            for(int i=1;i<=n;i++)
                result += i;
               return result;
        }
        //función que devuelva dos elevado a un nº
        public static void Potencia2 (double UserNumber)
        {
            
            if (UserNumber > 0 || UserNumber == 0)
            {
                double Constant = 1.0;
                for (int i = 0; i < UserNumber; i++)
                    Constant *= 2;
                System.Console.WriteLine("la solución es: " + Constant);
            }
            else
            {
                double result = 1.0;
                for (int i = 0; i > UserNumber; i--)
                    result *= 2;
                System.Console.WriteLine("la solución es: " + 1 / result);
            }
        }
    }
}
