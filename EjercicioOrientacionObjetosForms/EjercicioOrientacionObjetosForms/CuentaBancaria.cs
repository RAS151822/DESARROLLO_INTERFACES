using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOrientacionObjetosForms
{
    class Cuenta
    {
       private String num_Cuenta;
       private String nombre;
       private double saldo_Cuenta;
       private double tipoInteres;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Num_Cuenta { get => num_Cuenta; set => num_Cuenta = value; }
        public double Saldo_Cuenta { get => saldo_Cuenta; set => saldo_Cuenta = value; }
        public double TipoInteres { get => tipoInteres; set => tipoInteres = value; }


        public void Estado() {

            Console.WriteLine("Estado de la cuenta: \n");
            Console.WriteLine("Numero de cuenta: " + Num_Cuenta );
            Console.WriteLine("Nombre: " + nombre );
            Console.WriteLine("Saldo de Cuenta:" + Saldo_Cuenta);
            Console.WriteLine("Tipo de Interes: " + TipoInteres + "%\n");
            Console.ReadLine();

        }

      
    }
}
