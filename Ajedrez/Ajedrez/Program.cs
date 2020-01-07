using System;

namespace Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            Console.Write("Este es su tablero de ajedrez");
            // secuencia = Console.ReadLine();

            for (int i = 0; i < 8; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < 8; j++)
                {

                    if (j % 2 == 0)
                    {
                        Console.Write("N");
                    }
                    else
                    {
                        Console.Write("B");
                    }

                }


            }
            Console.WriteLine("Inserte las coordenadas de su alfil ");
            Console.WriteLine("Primero la X seria el eje horizontal");

            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ahora la Y seria el eje vertical");

            y = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < 8; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < 8; j++)
                {

                    if (j % 2 == 0)
                    {
                        Console.Write("N");
                    }
                    else
                    {
                        Console.Write("B");
                    }

                }

                Console.ReadLine();

            }
        }
    }
}
