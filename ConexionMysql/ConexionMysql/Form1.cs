using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;


namespace ConexionMysql
{
    public partial class Form1 : Form
    {

        MySqlConnection databaseConnection = new MySqlConnection(connection);
        static string connection = "datasource=127.0.0.1;port=3306;username=root;password=admin;database=cristomessenger;";


        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = llenar_grid();

           

        }


        public DataTable llenar_grid() {

            databaseConnection.Open();

            DataTable dt = new DataTable();

            string query = "SELECT * FROM user";

            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            
            da.Fill(dt);

            databaseConnection.Close();

            return dt;


           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxIdUser.Text != "")
            {
                databaseConnection.Open();

                string insertar = "INSERT INTO user(id_user,name,password,surname1,surname2,photo)values(@id_user,@name,@password,@surname1,@surname2,@photo)";
                MySqlCommand cmd = new MySqlCommand(insertar, databaseConnection);

                cmd.Parameters.AddWithValue("@id_user", textBoxIdUser.Text);
                cmd.Parameters.AddWithValue("@name", textBoxNombre.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                cmd.Parameters.AddWithValue("@surname1", textBoxApellido1.Text);
                cmd.Parameters.AddWithValue("@surname2", textBoxApellido2.Text);
                cmd.Parameters.AddWithValue("@photo", textBoxPhoto.Text);
                cmd.ExecuteNonQuery();

                databaseConnection.Close();

                MessageBox.Show("Los datos se insertaron con exito");

                dataGridView1.DataSource = llenar_grid();

            }
            else {

                MessageBox.Show("No puede insertar campos vacios");
            }
        }

      
    }
}
