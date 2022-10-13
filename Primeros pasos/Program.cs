using System;

namespace ejemplo_2
{
    class Program
    {

        static void Main(string[] args)
        {
            ejercicioswhile.Ejercicioserie1();
            ejercicioswhile.Ejercicioserie2();
            ejercicioswhile.Ejrcicioserie3();


                    
            double l1;
            l1 = geometric.CalculateVectorLegth(5.0, -4.0);

            double l2;
            l2 = geometric.CalculateDistance2D(0.0,0.0,1.0,1.0);
            /*
            double area;
            area = geometric.GetCircleArea(1.0);

            double volume;
            volume = geometric.GetVolume(2.0);

            */
            int min;
            min = Utils.GetMinValue(5,6);

            int max;
            max = Utils.GetMinValue(3,9);

            bool sol;
            sol = Utils.IsEven(5);

            ejercicioswhile.Ejercicio1();

            ejercicioswhile.Ejercicio2(5);


        }
        

    }
}
