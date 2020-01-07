using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            String secuencia = null;
            int contador = 0;

            Console.Write("Escriba una secuencia de numeros y le dire cuantos 7 contiene. \n");
            secuencia = Console.ReadLine();

            foreach(char c in secuencia)
            {
                if (c == '7') {

                    contador++;
                }
            }

            Console.Write("El numero de 7 que contiene son : " + contador);
            secuencia = Console.ReadLine();

        }

       
    }
}
