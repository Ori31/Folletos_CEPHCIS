using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFolletosCEPHCIS
{
    public partial class AddPage : Form
    {
        public AddPage()
        {
            InitializeComponent();
        }

        public bool IsUserGoingBack = false;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation = MessageBox.Show("¿Seguro que deseas volver?" + "\n" + "Se perderá el progreso no guardado.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Confirmation == DialogResult.Yes)
            {
                IsUserGoingBack = true;

                AdminMainPage AdminPage = new AdminMainPage();
                AdminPage.Show();
                this.Close();
            }
        }

        private void AddPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserGoingBack == false)
            {
                Application.Exit();
            }
        }

        private void AddPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string selectedFilePath;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string nombre = NameBox.Text;
            string autor = AutorBox.Text;
            string clave = KeywordBox.Text;
            string ubicacion = LocationBox.Text;
            string descripcion = DescriptionBox.Text;
            Libros nuevoLibro = new Libros(0, nombre, autor, clave, ubicacion, descripcion);
            int fila = nuevoLibro.AgregarLibro();

            if (fila == 1)
            {
                MessageBox.Show("Se ha guardado correctamente");
                Limpiar();

            }
            else
            {
                MessageBox.Show("Ocurrio un error, intente de nuevo");
                Limpiar();
            }

            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Por favor, selecciona un archivo primero.");
                return;
            }


            try
            {
                string destinationPath = Path.Combine(@"C:\Uploads", Path.GetFileName(selectedFilePath));
                Directory.CreateDirectory(@"C:\Uploads");
                File.Copy(selectedFilePath, destinationPath, true);

                SaveFileToDataBase(Path.GetFileName(selectedFilePath), destinationPath);

                MessageBox.Show("Archivo subido exitosamente.");
                selectedFilePath = null;
            }
            catch ( Exception ex)

            {
                MessageBox.Show($"Error al subir el archivo: {ex.Message}");
            }
        
        }
        private void Limpiar()
        {

            NameBox.Text = "";
            AutorBox.Text = "";
            KeywordBox.Text = "";
            LocationBox.Text = "";
            DescriptionBox.Text = "";


        }

        private void SaveFileToDataBase(string filename, string filepath)
        {
            string connectionString = "Data Source=LAPORI\\SQLEXPRESS;Initial Catalog=BD_Biblioteca;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PDF_FILES (filename,filepath)  VALUES (@filename,@filepath)";

                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@filename", filename);
                command.Parameters.AddWithValue("@filepath", filepath);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                Title = "Selecciona un archivo PDF"

            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
            }

        }
    }
}
