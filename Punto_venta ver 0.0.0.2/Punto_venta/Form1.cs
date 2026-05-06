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
            // Reemplaza "NombreTablaUsuarios" con el nombre real de tu tabla, y las columnas reales
            string consulta = "SELECT COUNT(*) FROM NombreTablaUsuarios WHERE usuario = @user AND contrasena = @pass";
            string connectionString = "server=localhost;database=tallerbd2026;uid=Programador;pwd=Lav3rga.2343";

            // Usamos using para asegurar que la conexión se cierre y libere correctamente al finalizar
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, cnn))
                {
                    // Utilizamos parámetros para evitar Inyección SQL (muy importante por seguridad)
                    comando.Parameters.AddWithValue("@user", textBox1.Text);
                    comando.Parameters.AddWithValue("@pass", textBox2.Text);

                    try
                    {
                        cnn.Open();
                        
                        // ExecuteScalar devuelve el primer valor de la consulta (en este caso el Count(*))
                        int usuarioExiste = Convert.ToInt32(comando.ExecuteScalar());

                        if (usuarioExiste > 0)
                        {
                            // Los datos son correctos, pasamos a la siguiente pantalla
                            Form2 nuevaPantalla = new Form2();
                            nuevaPantalla.FormClosed += (s, args) => this.Close(); 
                            nuevaPantalla.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Datos incorrectos
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar a la base de datos o ejecutar consulta: " + ex.Message);
                    }
                }
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
