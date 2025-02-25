using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFolletosCEPHCIS
{
    public partial class EditPage : Form
    {
        public EditPage()
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

        private void EditPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserGoingBack == false)
            {
                Application.Exit();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //PONER CÓDIGO PARA GUARDAR EL FOLLETO EN LA BASE DE DATOS DEBAJO DEL MESSAGEBOX

            int id = int.Parse(txt_id.Text);
            string nombre = Nomfolleto.Text;
            string autor = Autor.Text;
            string clave = txt_clave.Text;
            string ubicacion = txt_ubi.Text;
            string descripcion = txt_des.Text;

            DialogResult confirmar = MessageBox.Show("¿Desea realizar los cambios?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK)
            {
                Libros libro = new Libros(id, nombre, autor, clave, ubicacion, descripcion);
                int fila = libro.EditarLibros();

                if (fila == 1)
                {
                    MessageBox.Show("Se realizaron los cambios");
                    Limpiar();
                    ListarLibros();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }

            }
            else
            {

                Limpiar();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("¿Seguro que deseas eliminar el folleto?" + '\n' + "Esta acción no se puede deshacer.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            int id = Convert.ToInt32(txt_id.Text); 

            if (Delete == DialogResult.Yes)
            {
                //PONER CÓDIGO PARA ELIMINAR EL FOLLETO DE LA BASE DE DATOS DEBAJO DEL MESSAGEBOX
                Libros libro = new Libros(id);
                int fila = libro.EliminarContacto();


                if (fila == 1)
                {
                    MessageBox.Show("Eliminado");
                    ListarLibros();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, vuelva a intentar");
                }

            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            UploadDialog.ShowDialog();
        }

        private void EditPage_Load(object sender, EventArgs e)
        {
            ListarLibros();
        }

        public void ListarLibros()
        {
            Libros libro = new Libros();
            libro.CargarLibros(dataGridView1);
        }

        private void Limpiar()
        {
            Nomfolleto.Clear();
            Autor.Clear();
            txt_clave.Clear();
            txt_ubi.Clear();
            txt_des.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice == -1 || dataGridView1.SelectedCells[1].Value.ToString() == "")
            {
                MessageBox.Show("Seleccione registros validos");
            
            }
            else
            {
                txt_id.Text = dataGridView1.SelectedCells[0].Value.ToString();
                Nomfolleto.Text = dataGridView1.SelectedCells[1].Value.ToString();
                Autor.Text = dataGridView1.SelectedCells[2].Value.ToString();
                txt_clave.Text = dataGridView1.SelectedCells[3].Value.ToString();
                txt_ubi.Text = dataGridView1.SelectedCells[4].Value.ToString();
                txt_des.Text = dataGridView1.SelectedCells[5].Value.ToString();

             
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nomfolleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_des_TextChanged(object sender, EventArgs e)
        {

        }

        private void Autor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ubi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
