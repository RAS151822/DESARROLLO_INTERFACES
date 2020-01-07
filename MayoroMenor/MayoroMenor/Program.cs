using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayoroMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int primernumero = 0;
            int segundonumero = 0;


            Console.WriteLine("Bienvenido introduzca dos número y le dire cual es el mayor");
            Console.WriteLine("Introduzca el primer numero.");
           primernumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el primer numero.");
           segundonumero = int.Parse(Console.ReadLine());

            if(primernumero > segundonumero)
            {

                Console.WriteLine("El número mayor es: " + primernumero);
            }
            if(segundonumero > primernumero)
            {
                Console.WriteLine("El número mayor es: " + segundonumero);
            }
            if(primernumero == segundonumero)
            {
                Console.WriteLine("Los dos numeros son iguales.");
            }

            Console.ReadLine();
        }
    }
}
