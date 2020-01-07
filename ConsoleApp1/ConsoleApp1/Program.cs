using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primernumero = 0;
            int segundonumero = 0;


            Console.WriteLine("Bienvenido introduzca dos número y le dire si son pares");
            Console.WriteLine("Introduzca el primer numero.");
            primernumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el primer numero.");
            segundonumero = int.Parse(Console.ReadLine());

            if (primernumero % 2 == 0 && segundonumero % 2 == 0)
            {

                Console.WriteLine("Los dos números son pares: " + primernumero + " y " + segundonumero);
            }
            else {

                Console.WriteLine("Son impares");
            }

            Console.ReadLine();
        }
    }
}
