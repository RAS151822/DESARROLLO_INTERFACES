using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            int primernumero = 5;
            int segundonumero = 4;
            int resultado = 0;

            resultado = primernumero + segundonumero;
            Console.WriteLine(resultado);
            Console.ReadLine();

            resultado = primernumero - segundonumero;
            Console.WriteLine(resultado);
            Console.ReadLine();


            resultado = primernumero * segundonumero;
            Console.WriteLine(resultado);
            Console.ReadLine();


            resultado = primernumero / segundonumero;
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
