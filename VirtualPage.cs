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
    public partial class VirtualPage : Form
    {
        public VirtualPage()
        {
            InitializeComponent();
        }

        public bool IsUserGoingBack = false;

        private void BackButton_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;

            GuestSearchPage infoPage = new GuestSearchPage();
            infoPage.Show();
            this.Close();
        }

        private void VirtualPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserGoingBack == false)
            {
                Application.Exit();
            }
        }

        private void NameText_Click(object sender, EventArgs e)
        {
            
        }

        public string Busqueda { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPORI\\SQLEXPRESS;Initial Catalog=BD_Biblioteca;Integrated Security=True";

                
                string nombreFolleto = txtFolleto.Text.Trim();
                if (string.IsNullOrEmpty(nombreFolleto))
                {
                    MessageBox.Show("Por favor, selecciona un folleto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Consulta SQL para buscar el PDF
                string query = "SELECT PdfFile FROM PDF_Files WHERE FileName LIKE @Name";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", nombreFolleto);

                    connection.Open();

                    // Recupera los datos binarios del PDF
                    byte[] pdfData = command.ExecuteScalar() as byte[];

                    if (pdfData != null)
                    {
                        // Guarda el archivo temporalmente y lo abre
                        string tempPath = Path.Combine(Path.GetTempPath(), $"{nombreFolleto}.pdf");
                        File.WriteAllBytes(tempPath, pdfData);

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = tempPath,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el archivo PDF para el folleto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VirtualPage_Load(object sender, EventArgs e)
        {
            txtFolleto.Text = Busqueda;
        }
    }
}
