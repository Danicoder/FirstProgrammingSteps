using System;

namespace Calculate
{
    class Program
    {
            public static void Main(string[] arg)
            {
                for (; ;)
                {
                    UserInterface.PrintMainMenu();
                    int option = Utils.ReadInteger();
                    switch (option)
                    {
                        case 1:
                            System.Console.Clear();
                            UserInterface.PrintHeader1();
                            int NumberUser1 = Utils.ReadInteger();
                            double ResultOption1 = ModelConsole.LaunchPower2(NumberUser1);
                            System.Console.WriteLine("El resultado de  "+ NumberUser1 + " = " + ResultOption1+ "\n ");
                            System.Console.WriteLine("Teclea intro para ir al menu principal");
                            System.Console.ReadLine();
                            System.Console.Clear();
                            break;
                        case 2:
                            System.Console.Clear();
                            UserInterface.PrintHeader2();
                            int NumberUser2 = Utils.ReadInteger();
                            int ResultOption2 = ModelConsole.GiveSumatory(NumberUser2);
                            System.Console.WriteLine("El resultado de  " + NumberUser2 + " = " + ResultOption2+"\n");
                            System.Console.WriteLine(" Teclea intro para ir al menu principal ");
                            System.Console.ReadLine();
                            System.Console.Clear();
                            break;
                        case 3:
                            System.Console.Clear();
                            UserInterface.PrintHeader3();
                            int NumberUser3 = Utils.ReadInteger();
                            int ResultOption3 = ModelConsole.LaunchFactorialNumber(NumberUser3);
                            if (NumberUser3 < 0)
                                System.Console.Write("No se puede calcular el factorial de un número negativo");
                            if (NumberUser3 == 0)
                                System.Console.Write("0! = 1");
                            System.Console.Write("El resultado de "+ NumberUser3+ " = "+ ResultOption3 + "!\n");
                            System.Console.WriteLine("Teclea intro para ir al menu principal");
                            System.Console.ReadLine();
                            System.Console.Clear();
                            break;
                        case 4:
                            System.Console.Clear();
                            UserInterface.PrintHeader4(); 
                            int NumberUser4 = Utils.ReadInteger();
                            bool ResultOption4 = ModelConsole.LaunchIsPrime(NumberUser4);
                            if(ResultOption4 == false)
                            {
                                System.Console.WriteLine("No es primo \n");
                            }
                            else System.Console.WriteLine("Es primo \n");
                            System.Console.WriteLine("Teclea intro para ir al menu principal");
                            System.Console.ReadLine();
                            System.Console.Clear();
                            break;
                        case 5:
                            System.Console.Clear();
                            UserInterface.PrintHeader5();
                            int NumberUser5 = Utils.ReadInteger();
                            if(NumberUser5 > 0)
                            {
                                string ResultOption5 = ModelConsole.LaunchFibonacci(NumberUser5);
                                System.Console.WriteLine("La sucesión de Fibonacci es:  " + ResultOption5 + "\n");
                                System.Console.WriteLine("Teclea intro para ir al menu principal");
                                System.Console.ReadLine();
                                System.Console.Clear();
                            }
                            else
                            {
                                System.Console.WriteLine("Error: has introducido un número negativo");
                                System.Console.WriteLine("Teclea intro para ir al menu principal");
                                System.Console.ReadLine();
                                System.Console.Clear();
                            }
                            break;
                        case 0:
                        System.Console.WriteLine("¡Espero que te haya ayudado!\n GOOD LUCK");
                        System.Threading.Thread.Sleep(2000);
                        return;
                    }
                }
            }
    }
    
}