using System;
using System.Collections.Generic;

namespace Prueba
{
    class Program
    {
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

            for (int i = 0; i < intNumbers.Count; i++)
            {
                Console.WriteLine(intNumbers[i]);
            }
            for (int i = 0; i < intNumbers.Count - 1; i++)
            {
                for (int j = i + 1; j < intNumbers.Count; j++)
                {
                    if (intNumbers[1] > intNumbers[j])
                    {
                        //intercambiarlo, en tres líneas. intentar intercambiar los valores
                    }
                }
            }
        }
    }
}
