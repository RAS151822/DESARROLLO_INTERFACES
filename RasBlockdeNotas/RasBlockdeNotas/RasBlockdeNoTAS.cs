using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RasBlockdeNotas
{
    public partial class RasBlockdeNotas : Form
    {
        public RasBlockdeNotas()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void estiloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpen = new OpenFileDialog();
            StreamReader myReader = null;

            myOpen.Filter = "Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            myOpen.Title = "Abrir archivo ";
            myOpen.ShowDialog();
            myOpen.OpenFile();
            String rutaArchivo = myOpen.FileName;


            myReader = File.OpenText(rutaArchivo);
            richTextBox1.Text = myReader.ReadToEnd(); 

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog imprimir = new PrintDialog();
            imprimir.ShowDialog();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarcomo = new SaveFileDialog();
            StreamWriter myWriter = null;

            guardarcomo.Filter = "Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            guardarcomo.Title = "Guardar como...";
            guardarcomo.ShowDialog();
            String rutaArchivo = guardarcomo.FileName;
            myWriter = File.AppendText(rutaArchivo);
            myWriter.Write(richTextBox1.Text);
            myWriter.Flush();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
