using System;

namespace DiasDelMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias = 0;
            int caseSwitch = 0;
            int año = 0;
           

            Console.WriteLine("Bienvenido Al programa para saber los dias que tiene un MES en el AÑO que DESEE! Introduzca el número del Mes que desea");
           caseSwitch = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Perfectp! Ahora Introduzca el AÑO");
            año = Convert.ToInt16(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    dias = 31;
                    Console.WriteLine("Ha elegido usted, ENERO");
                    Console.WriteLine("Enero en el año " + año + " tiene " + dias);
                    break;
                case 2:

                    if (año%4 == 0) {

                        if (año%100 == 0)
                        {
                            dias = 29;
                        }
                    }
                    else {
                        dias = 28;
                    }

                    Console.WriteLine("Ha elegido usted, FEBRERO");
                    Console.WriteLine("Febrero en el año " + año + " tiene " + dias);
                    break;
                case 3:
                    dias = 31; 
                    Console.WriteLine("Ha elegido usted, MARZO");
                    Console.WriteLine("Marzo en el año " + año + " tiene " + dias);
                    break;
                case 4:
                    dias = 31;
                    Console.WriteLine("Ha elegido usted, ABRIL");
                    Console.WriteLine("Enero en el abril " + año + " tiene " + dias);
                    break;
                case 5:
                    dias = 31;
                    Console.WriteLine("Ha elegido usted, MAYO");
                    Console.WriteLine("Enero en el mayo " + año + " tiene " + dias);
                    break;
                case 6:
                    dias = 30;
                    Console.WriteLine("Ha elegido usted, JUNIO");
                    Console.WriteLine("junio en el año " + año + " tiene " + dias);
                    break;
                case 7:
                    dias = 31;
                    Console.WriteLine("Ha elegido usted, JULIO");
                    Console.WriteLine("Julio en el año " + año + " tiene " + dias);
                    break;
                case 8:
                    dias = 31;
                    Console.WriteLine("Ha elegido usted, AGOSTO");
                    Console.WriteLine("Agosto en el año " + año + " tiene " + dias);
                    break;
                case 9:
                    dias = 30;
                    Console.WriteLine("Ha elegido usted, SEPTIEMBRE");
                    Console.WriteLine("Septiembre en el año " + año + " tiene " + dias);
                    break;
                case 10:
                    dias = 31;
                    Console.WriteLine("Ha elegido usted, OCTUBRE");
                    Console.WriteLine("Octubre en el año " + año + " tiene " + dias);
                    break;
                case 11:
                    dias = 30;
                    Console.WriteLine("Ha elegido usted, NOVIEMBRE");
                    Console.WriteLine("Noviembre en el año " + año + " tiene " + dias);
                    break;
                case 12:
                    dias = 31;
                    Console.WriteLine("Ha elegido usted, DICIEMBRE");
                    Console.WriteLine("Diciembre en el año " + año + " tiene " + dias);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.ReadLine();
        }
    }
}
