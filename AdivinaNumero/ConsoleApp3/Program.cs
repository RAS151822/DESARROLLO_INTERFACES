using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primernumero = 0;
            int segundonumero = 0;
            int contador = 0;


            Console.WriteLine("Bienvenido primer jugador  introduzca un numero del 0 al 20 y el segundo intentara adivinarlo.");
            Console.WriteLine("Introduzca el numero.");
           

            do
            {
                primernumero = int.Parse(Console.ReadLine());

                if (primernumero < 0 || primernumero > 20)
                {
                    Console.WriteLine(" Recuerda Introduzca un valor entre el 0 y el 20 ambos inclusive");
                   
                }

            } while (primernumero < 0 || primernumero > 20);

            Console.Clear();
            Console.WriteLine("Perfecto,  Bienvenido intente  adivinar el introducido por el primer jugador tiene 5 intentoos!.");
            Console.WriteLine("Introduzca el numero.");
            segundonumero = int.Parse(Console.ReadLine());
           

            do
            {
                contador++;

                if (primernumero == segundonumero)
                {
                    Console.WriteLine(" Acertaste Los dos numeros son iguales.");

                }
                else
                {
                    if (primernumero > segundonumero)
                    {

                        Console.WriteLine("Uyyy El número " + segundonumero + " es menor que el primero.");
                       
                    }
                    if (segundonumero > primernumero)
                    {
                        Console.WriteLine("Casiii!! El número " + segundonumero + " es mayor que el primero.");
                    }

                    if (contador == 5)
                    {
                        Console.WriteLine("Lo siento ya no tienes mas intentos... contador = " + contador);
                    }

                    Console.WriteLine("Introduzca el numero.");
                    segundonumero = int.Parse(Console.ReadLine());
                }

               

            } while (primernumero != segundonumero && contador != 5);

            Console.ReadLine();
        }
    }
}
