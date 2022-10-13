using System;
using System.Collections.Generic;

namespace prueba
{
    class Program
    {
       /*-5 -2 0 3 5 9 11 12 17 21 32 40 45 50*
        algoritmo para buscar un numero*/
       //
       public static bool BinarySearch(List<int> list, int number)
       {
            int min = 0;
            int max = list.Count -1;
            while (min <= max)
            {
                int middel = (min + max) / 2;
                if (list[middel] < number)
                    min = middel + 1;
                else if (list[middel] > number)
                    min = middel - 1;
                else
                    return true;
            }
            return false;
       }
        //funcion que le pasemos una lista y un numero y nos diga(bool) si el numero esta en la lista o no
       public static bool ContaintsNumbers(List<int> list, int number)
       {
            for(int i = 0; i < list.Count;i++)
            {
                if (number == list[i])//[i]posicion
                    return true;
            }
            return false;
        }
        //oredenar la lista
        public static void OrderList(List<int> list)
       {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        //intercambiar los valores (siempre tendrá el mismo orden)
                        int aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            }
       }
        //imprimir lista
        public static void Printlist(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + "\n");
            }
        }
        static void Main()
        {
            List<int> intNumbers = new List<int>();

            intNumbers.Add(3);
            intNumbers.Add(-1);
            intNumbers.Add(4);
            intNumbers.Add(0);
            intNumbers.Add(8);
            intNumbers.Add(7);
            intNumbers.Add(-1);
            intNumbers.Add(2);
            intNumbers.Add(0);

            Printlist(intNumbers);
            OrderList(intNumbers);
            Printlist(intNumbers);
            bool result = ContaintsNumbers(intNumbers, 0);
            if (result == true)
                Console.WriteLine("El número SI esta en la lista");
            else Console.WriteLine("El número NO esta en la lista");
            BinarySearch(intNumbers,2);
        }
    }
}
