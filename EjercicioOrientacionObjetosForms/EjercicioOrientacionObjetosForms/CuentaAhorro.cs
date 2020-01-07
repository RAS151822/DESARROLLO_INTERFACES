using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOrientacionObjetosForms
{
     class CuentaAhorro : Cuenta
    {
       private double cuotaMantenimiento;

        public double CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}
