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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            CuentaAhorro C01 = new CuentaAhorro();
            C01.Num_Cuenta = "ES5464646582015";
            C01.Nombre = "Raul Arenas";
            C01.Saldo_Cuenta = 487.15;
            C01.TipoInteres = 15;



            textNCuenta.Text = C01.Num_Cuenta;
            textName.Text = C01.Nombre;
            textSaldo.Text = C01.Saldo_Cuenta.ToString();
            textTipodeInteres.Text = C01.TipoInteres.ToString();


        }

        
        private void button2_Click_2(object sender, EventArgs e)
        {
            Form2 CuentaAhorroVentana = new Form2();
            CuentaAhorroVentana.Show();
            this.Visible=false;

        }
    }
}
