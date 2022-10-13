using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    class tEmpleado
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private string dni;
        private int edad;

        /*Si quito static necesito crear una ocurrencia de esa clase, lo que hace es que eso es común para todos los elementos que
         utilizen esa variable, todos los objetos*/
        public void Imprime()
        {
            Console.WriteLine("Tu edad es:" + edad);
        }
        //guarda el valor de la edad
        public void setEdad(int a)
        {
            edad = a;
        }
        public void MayorMenor()
        {
            if (edad < 18)
                Console.WriteLine("Es menor de edad");
            else Console.WriteLine("Es mayor de edad");
        }
        class directivo : tEmpleado
        {
            private string cargo;
            public void SetCargo(string valor)
            {
                cargo = valor;
            }
        }
    }
}
