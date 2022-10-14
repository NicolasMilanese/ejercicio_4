using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string convercion,convercion1;
            int dolar,euro,resultado;

            convercion="dolar";
            convercion="euro";
            convercion="s";
            

            Console.WriteLine ("escriba la convercion que desea realizar dolar, euro");
        
        while (convercion=="dolar"||convercion=="euro"||convercion=="s"||convercion=="S")
        {
            Console.WriteLine("Si desea realizar la convercion de dolar ingrese dolar sino saltee");
            convercion=Console.ReadLine();
            
            if (convercion =="dolar")
            {
            Console.WriteLine("escriba cuantos dolar quiere pasar a peso");
            convercion1=Console.ReadLine();
            dolar=Convert.ToInt32(convercion1);
            resultado=dolar*293;

            Console.WriteLine("la convercion de dolar a pesos es " + resultado);

            }

            Console.WriteLine("si desea realizar la convercion de euro ingrese euro sino saltee");
            convercion=Console.ReadLine();

            if (convercion=="euro")
            {
            Console.WriteLine("escriba cuantos euro quiere pasar a peso");
            convercion1=Console.ReadLine();
            euro=Convert.ToInt32(convercion1);
            resultado=euro*275;
                
            Console.WriteLine ("la convercion de euro a pesos es " + resultado);
            } 

            Console.WriteLine ("si desea realizar otra convercion ingrese s");
            Console.WriteLine("Si desea salir ingrese salir");
            convercion=Console.ReadLine();

           
        }
        

        }
    } 
        
 }
