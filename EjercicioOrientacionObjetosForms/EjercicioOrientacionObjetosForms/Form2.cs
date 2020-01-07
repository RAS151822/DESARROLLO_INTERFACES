using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioOrientacionObjetosForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CuentaAhorro c = new CuentaAhorro();
            c.CuotaMantenimiento = 35.60;
            label1.Text = c.CuotaMantenimiento.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
