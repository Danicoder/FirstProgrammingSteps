
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
    }
}
