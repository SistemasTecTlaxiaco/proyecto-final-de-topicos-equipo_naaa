
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
                // Genera el hash binario de la contraseña
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
            formCrearUsuario.Show(); // Muestra el formulario de creación de usuario
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
    
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            FormCONTRASEÑA formCont = new FormCONTRASEÑA();
            formCont.FormClosed += (s, args) => this.Close(); // Cierra todo cuando se cierra FormRecupCont
            formCont.Show(); // Muestra el formulario de recuperación de contraseña
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        { // Obtiene los valores de los campos de texto
            string nombre = TextBoxUsuario.Text.Trim();
            string password = TextBoxContraseña.Text;

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
             // Genera el hash de la contraseña ingresada
            string passwordHash = HashPasswordSHA256(password);

            try
            {
                // Establece una conexión a la base de datos
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para verificar el usuario y la contraseña
                    string query = "SELECT contraseña FROM usuario WHERE nombre = @nombre";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        // Agrega el parámetro de nombre al comando SQL
                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        // Ejecuta la consulta y lee los resultados
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtiene el hash de contraseña almacenado en la base de datos
                                string hashFromDb = reader.GetString(0);

                                // Compara el hash de la contraseña ingresada con el hash de la base de datos
                                if (hashFromDb == passwordHash)
                                {
                                    // Inicio de sesión exitoso
                                    MessageBox.Show("Inicio de sesión exitoso.");
                                    this.Hide(); // Oculta el formulario actual

                                    // Abre el formulario principal después del inicio de sesión
                                    FormINICIO formInicio = new FormINICIO();
                                    formInicio.FormClosed += (s, args) => this.Close(); // Cierra todo cuando se cierra FormInicio
                                    formInicio.Show();
                                }
                                else
                                {
                                    // Contraseña incorrecta
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
                // Maneja errores de conexión a la base de datos
                MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}");
            }
        }
    }
}
