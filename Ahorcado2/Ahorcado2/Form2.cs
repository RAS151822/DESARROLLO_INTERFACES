﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado2
{
    public partial class Form2 : Form
    {
        char[] PalabrasAdivinadas;
        int Oportunidades;
        char[] PalabraSeleccionada;
        char[] Alfabeto;
        String[] Palabras;
        Button Letra;
        int opcionElegida;


        public void IniciarJuego()
        {

            //Aqui iniciaremos
            flFichasDeJuego.Controls.Clear();
            flFichasDeJuego.Enabled = true;

            picAhorcado1.Image = null;
            picAhorcado2.Image = null;
            picAhorcado3.Image = null;
            picAhorcado4.Image = null;
            picAhorcado5.Image = null;
            picAhorcado6.Image = null;
            picAhorcado7.Image = null;
            picAhorcado8.Image = null;
            picAhorcado9.Image = null;
            picAhorcado10.Image = null;
            picAhorcado11.Image = null;

            lblMensaje.Visible = false;
            label2.Visible = false;
            Oportunidades = 0;
            Palabras = new String[] { "arbol", "gato", "perro", "teclado", "raton", "ordenador", "cenicero", "television", "ventana", "mechero", "estanteria", "colonia", };
            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToArray();

            //palabra aleatoria - adivinar
            Random random = new Random();
            int IndicePalabraSeleccionada = random.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToArray();
            PalabrasAdivinadas = PalabraSeleccionada;

            //Ciclo que carga el alfabeto en un flowlayout -- > flFichasDeJuego

            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Height = 40;
                btnLetra.Width = 60;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichasDeJuego.Controls.Add(btnLetra);


                if (opcionElegida == 2)
                {
                    Console.WriteLine("LLega aqui!!!!");
                    Char[] destapa = new Char[3];

                    for (int i = 0; i < opcionElegida; i++)
                    {
                        destapa[i] = PalabraSeleccionada[i]; //las dos letras estan aqui, como se desactivan los botones y como se muestran las letras
                        Console.WriteLine(destapa[i]);
                        Console.WriteLine("LLega aqui!!!!");
                    }


                    if (destapa[0].ToString() == btnLetra.Text)
                    {

                        Console.WriteLine("Entra");
                        btnLetra.BackColor = Color.White;
                        btnLetra.Enabled = false;



                    }

                    if (destapa[1].ToString() == btnLetra.Text)
                    {

                        Console.WriteLine("Entra");
                        btnLetra.BackColor = Color.White;
                        btnLetra.Enabled = false;

                    }

                    //ifbtnLetra.Name




                }


            }



            flPalabra.Controls.Clear();

            //Ciclo que agrega la palabra en un flowlayout (palabra a adivinar)
            for (int i = 0; i < PalabraSeleccionada.Length; i++)
            {
                Letra = new Button();
                Letra.Tag = PalabraSeleccionada[i].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.Black;
                Letra.Text = "-";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinado" + i.ToString();
                flPalabra.Controls.Add(Letra);

                if (opcionElegida == 2)
                {
                    Console.WriteLine("LLega aqui!!!!");
                    Char[] destapa = new Char[3];

                    for (int x = 0; x < opcionElegida; x++)
                    {
                        destapa[x] = PalabraSeleccionada[x]; //las dos letras estan aqui, como se desactivan los botones y como se muestran las letras
                        Console.WriteLine(destapa[x]);
                        Console.WriteLine("LLega aqui!!!!");
                    }


                    if (destapa[0] == PalabraSeleccionada[i])
                    {

                        Console.WriteLine("Entra");
                        Letra.Text = destapa[0].ToString();
                        Console.WriteLine(Letra.Text);


                    }

                    if (destapa[1] == PalabraSeleccionada[i])
                    {

                        Console.WriteLine("Entra");
                        Letra.Text = destapa[1].ToString();

                    }



                }

                //---------------------------------------------------------------------------------------------------------------------------------

                if (opcionElegida == 1)
                {
                    Console.WriteLine("LLega aqui!!!!");
                    Char[] destapa = new Char[3];

                    for (int x = 0; x < opcionElegida; x++)
                    {
                        destapa[x] = PalabraSeleccionada[x]; //las dos letras estan aqui, como se desactivan los botones y como se muestran las letras
                        Console.WriteLine(destapa[x]);
                        Console.WriteLine("LLega aqui!!!!");
                    }


                    if (destapa[0] == PalabraSeleccionada[i])
                    {

                        Console.WriteLine("Entra");
                        Letra.Text = destapa[0].ToString();
                        Console.WriteLine(Letra.Text);


                    }




                }
            }



            void Compara(object sender, EventArgs e)
            {
                label2.Visible = false;
                //boton presionado se desactiva
                bool encontrado = false;
                Button btn = (Button)sender;
                btn.BackColor = Color.White;
                btn.Enabled = false;





                //compara la letra seleccionada con las letras de la palabra
                for (int i = 0; i < PalabrasAdivinadas.Length; i++)
                {
                    char charAux = '9';
                    charAux = Char.Parse(btn.Text);
                    if (PalabrasAdivinadas[i] == Char.Parse(btn.Text))
                    {
                        //si existe la letra actualiza la palabra agregando el valor correspondiente
                        Button tbx = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                        PalabrasAdivinadas[i] = '-';
                        tbx.Text = charAux.ToString();


                        encontrado = true;
                    }

                }

                //verifica si todas las letras de la palabra estan destapadas
                bool Ganaste = false;

                for (int i = 0; i < PalabrasAdivinadas.Length; i++)
                {
                    //Si el usuario tiene letras pendientes por destapar se cambia el estatus
                    if (PalabrasAdivinadas[i] != '-')
                    {
                        Ganaste = true;
                    }

                }

                //Si el estatus de la variable no cambia quiere decir el usuario gano
                if (!Ganaste)
                {
                    MessageBox.Show("Has Ganado Maquina!!");/* btnIniciarJuego.Image = Properties.Resources.btnStart;*/ //--------------Aqui poner foto diferente------------------
                }

                //si no se encuentra niguna letra de la palabra
                if (!encontrado)
                {
                    Oportunidades = Oportunidades + 1;

                    if (Oportunidades == 1)
                    {
                        picAhorcado1.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 2)
                    {
                        picAhorcado2.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 3)
                    {
                        picAhorcado3.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 4)
                    {
                        picAhorcado4.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 5)
                    {
                        picAhorcado5.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 6)
                    {
                        picAhorcado6.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 7)
                    {
                        picAhorcado7.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 8)
                    {
                        picAhorcado8.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 9)
                    {
                        picAhorcado9.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 10)
                    {
                        picAhorcado10.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }

                    if (Oportunidades == 11)
                    {
                        picAhorcado11.ImageLocation = @"C:\Users\RASPUTIN\source\repos\Ahorcado2\Ahorcado2\Resources\Ahorcado" + Oportunidades + ".png";
                    }
                    //picAhorcado.Image = Image.FromFile("F:\ahorcado\ahorcado8.png");
                }

                //se han acabado las oportunidades(mostrar mensaje)
                if (Oportunidades == 11)
                {
                    lblMensaje.Visible = true;
                    //Muestra la palabra que el usuario intentaba adivinar
                    for (int i = 0; i < PalabraSeleccionada.Length; i++)
                    {
                        Button btnLetra = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                        btnLetra.Text = btnLetra.Tag.ToString();
                    }

                    //desactiva las fichas y cambia el boton de reinicio
                    flFichasDeJuego.Enabled = false;
                    // btnIniciarJuego.Image = Properties.Resources.btnStart; -----------------------------------------aqui--------------------------
                }

            }


        }
        public Form2(int opcion)
        {
            opcionElegida = opcion;
            InitializeComponent();
            IniciarJuego();
            lblMensaje.Visible = false;
            label2.Visible = false;

            picAhorcado1.Image = null;
            picAhorcado2.Image = null;
            picAhorcado3.Image = null;
            picAhorcado4.Image = null;
            picAhorcado5.Image = null;
            picAhorcado6.Image = null;
            picAhorcado7.Image = null;
            picAhorcado8.Image = null;
            picAhorcado9.Image = null;
            picAhorcado10.Image = null;
            picAhorcado11.Image = null;


            this.Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarJuego_Click_1(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
