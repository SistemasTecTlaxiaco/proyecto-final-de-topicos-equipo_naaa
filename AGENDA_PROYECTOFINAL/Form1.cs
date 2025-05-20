
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;
namespace AGENDA_PROYECTOFINAL
{
    public partial class FormAcceso : Form
    {
        string connectionString = "server=localhost;port=3307;database=agenda;uid=root;pwd=Nalley09;";
        public FormAcceso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Genera el hash binario de la contrase�a
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convierte el hash binario en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            CrearUsuario formCrearUsuario = new CrearUsuario();
            formCrearUsuario.FormClosed += (s, args) => this.Close(); // Cierra todo cuando se cierra FormCrearUsuario
            formCrearUsuario.Show(); // Muestra el formulario de creaci�n de usuario
        }

        private void textContrase�a_TextChanged(object sender, EventArgs e)
        {
    
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            FormCONTRASE�A formCont = new FormCONTRASE�A();
            formCont.FormClosed += (s, args) => this.Close(); // Cierra todo cuando se cierra FormRecupCont
            formCont.Show(); // Muestra el formulario de recuperaci�n de contrase�a
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        { // Obtiene los valores de los campos de texto
            string nombre = TextBoxUsuario.Text.Trim();
            string password = TextBoxContrase�a.Text;

            // Validaci�n de campos vac�os
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
             // Genera el hash de la contrase�a ingresada
            string passwordHash = HashPasswordSHA256(password);

            try
            {
                // Establece una conexi�n a la base de datos
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para verificar el usuario y la contrase�a
                    string query = "SELECT contrase�a FROM usuario WHERE nombre = @nombre";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        // Agrega el par�metro de nombre al comando SQL
                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        // Ejecuta la consulta y lee los resultados
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtiene el hash de contrase�a almacenado en la base de datos
                                string hashFromDb = reader.GetString(0);

                                // Compara el hash de la contrase�a ingresada con el hash de la base de datos
                                if (hashFromDb == passwordHash)
                                {
                                    // Inicio de sesi�n exitoso
                                    MessageBox.Show("Inicio de sesi�n exitoso.");
                                    this.Hide(); // Oculta el formulario actual

                                    // Abre el formulario principal despu�s del inicio de sesi�n
                                    FormINICIO formInicio = new FormINICIO();
                                    formInicio.FormClosed += (s, args) => this.Close(); // Cierra todo cuando se cierra FormInicio
                                    formInicio.Show();
                                }
                                else
                                {
                                    // Contrase�a incorrecta
                                    MessageBox.Show("Datos incorrectos o inexistentes.");
                                }
                            }
                            else
                            {
                                // Usuario no encontrado
                                MessageBox.Show("Datos incorrectos o inexistentes.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja errores de conexi�n a la base de datos
                MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}");
            }
        }
    }
}
