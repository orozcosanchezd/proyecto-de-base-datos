using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Creamos una instancia del nuevo formulario al que queremos ir
            Form2 nuevaPantalla = new Form2();

            // Nos aseguramos que al cerrar el Form2, se cierre por completo la aplicación (Form1)
            nuevaPantalla.FormClosed += (s, args) => this.Close();

            // Mostramos el nuevo formulario
            nuevaPantalla.Show();

            // Ocultamos el formulario actual (el de inicio de sesión)
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string connectionString = null;
            MySqlConnection cnn;
            MySqlCommand SentenciaMySql;
            MySqlDataReader mySqlDataReader;

            connectionString = "server=localhost;database=tallerbd2026;uid=Programador;pwd='Lav3rga.2343'";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
            }


            Form2 nuevaPantalla = new Form2();

            // Mostramos el nuevo formulario
            nuevaPantalla.Show();

            // Ocultamos el formulario actual (el de inicio de sesión)
            this.Hide();

                        


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
