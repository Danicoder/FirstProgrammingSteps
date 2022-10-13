using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class UserInterface
    {

        public static void PrintHeader5()
        {
            Utils.PrinMenu();
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine("Succesión Fibonacci");
            System.Console.WriteLine("-------------------");
            System.Console.ResetColor();
            System.Console.WriteLine("La sucesión de Fibonacci es una sucesión infinita de números naturales.\n" +
                " 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377……….. La sucesión comienza con los números 0 y 1,\n" +
                " y a partir de estos, cada elemento es la suma de los dos anteriores.\n");
            System.Console.WriteLine("\nTeclea el número\n");
        }
        public static void PrintHeader4()
        {
            Utils.PrinMenu();
            System.Console.WriteLine("------------");
            System.Console.WriteLine("Número Primo");
            System.Console.WriteLine("------------");
            System.Console.ResetColor();
            System.Console.WriteLine("Un número primo es un número entero mayor que cero, que tiene exactamente dos divisores positivos.\n " +
                "También podemos definirlo como aquel número que no puede expresarse como producto de dos números enteros positivos \n" +
                "más pequeños que él, o bien, como producto de dos enteros positivos de más de una forma.\nConviene observar que con cualquiera de las " +
                "dos definiciones el 1 queda excluido del conjunto de los números primos.\n");
            System.Console.WriteLine("\n¿Cúal número quieres saber sí es primo o no? Teclealo\n");
        }
        public static void PrintHeader3()
        {
            Utils.PrinMenu();
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Factorial de un número");
            System.Console.WriteLine("----------------------");
            System.Console.ResetColor();
            System.Console.WriteLine("La función factorial se representa con un signo de exclamación “!” detrás de un número.\n " +
                "Esta exclamación quiere decir que hay que multiplicar\n todos los números enteros positivos que hay entre ese número natural y el 1\n " +
                "también hay que tener en cuenta que el 0 en este caso tendrá un valor distinto.\n");
            System.Console.WriteLine("\nTeclea el número a factorizar\n");
        }
        public static void PrintHeader2()
        {
            Utils.PrinMenu();
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Sumatorio de un número");
            System.Console.WriteLine("----------------------");
            System.Console.ResetColor();
            System.Console.WriteLine("la operación de suma es un operador matemático \nque permite representar sumas de muchos sumandos, incluso infinitos sumandos.\n" +
                "Aunque no hay números \nnegativos porque en dicho caso se realizaría el valor absoluto del mismo.");
            System.Console.WriteLine("\nTeclea el número que deseas sumar\n");
        }
        public static void PrintHeader1 ()
        {
            Utils.PrinMenu();
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Potencia en base 2");
            System.Console.WriteLine("------------------");
            System.Console.ResetColor();
            System.Console.WriteLine("Una potencia es el resultado de multiplicar un número por sí mismo varias veces.\nEl número que multiplicamos es la base," +
                " mientras que el número de veces que multiplicamos la base se llama exponente");
            System.Console.WriteLine("\nIntroduce el número a calcular\n");
        }
        /*Como para la mayoria de los casos son números naturales utilizamos int*/
        public static void PrintMainMenu()
        {
            Utils.PrinMenu();
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Menú principal");
            System.Console.WriteLine("--------------");
            System.Console.ResetColor();
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatorio de un número");
            System.Console.WriteLine("3) Calcular el factorial de un número"); 
            System.Console.WriteLine("4) Saber si un número es primo");
            System.Console.WriteLine("5) Imprimir sucesión de Fibonacci");
            System.Console.WriteLine("0) Salir del programa");

            System.Console.WriteLine("\nEscribe la opción que deseas escoger\n");
        }
    }
}
