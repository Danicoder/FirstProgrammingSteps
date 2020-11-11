using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebaclase1
{
    class Exercises
    {
        // salvo que ponga imprime por pantalla "console.writeline" (es solo para aplicacion de consola o para mensajes de debood)
        // recordar el MVC (en relacion a console.writeline)
        //Hacer una función que imprima por pantalla los números del 0 al 100
        public static void Ejercicioserie1()
        {
            int i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine("La solución es:" + i);
                i++;

                // contador = contador + 1;
                // contador += 1;
            }
        }
        //función que imprima por pantalla todos los números pares desde el 0 hasta 100 (2,4,6,8...)
        
        public static void Ejercicioserie2()
        {
            int i = 1;
            while (i <= 100)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine("la solución es:" +i);
                    i++;
            }
        }
        //ejercicio donde salgan los número así: 1, 4, 7, 10 ,13...
        public static void Ejercicioserie3()
        {
            int i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine("La solución es:" + (i * 3) + 1);
                i++;

                // contador = contador + 1;
                // contador += 1;
            }
        }
        //ejercicio que imprima: 0, 1, 4, 9, 16, 25 36.........
        public static void Ejercicioserie4()
        {
            int i = 0;
            while(i <= 100)
            {
                System.Console.WriteLine("La solución es:"+i * i);
                i++;
            }
        }
        //ejercicio que imprima por pantalla: 0, -1, 2, -3, 4, -5, 6, -7, 8, ......100
        public static void Ejercicioserie5()
        {
            int i = 0;
            while( i <= 100)
            {
                if(Utils.IsEven(i))
                    System.Console.WriteLine(i);
                else

                    System.Console.WriteLine(-i);
                    i++;  
            }
        }




    }
}
