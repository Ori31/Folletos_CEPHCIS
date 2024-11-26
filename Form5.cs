using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 forms = new Form3();
            forms.Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ListarLibros();
        }

        public void ListarLibros() {
            Libros libro = new Libros();
            libro.CargarLibros(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if(indice == -1 || dataGridView1.SelectedCells[1].Value.ToString() == "")
            {
                MessageBox.Show("Seleccione registros validos");
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            } else
            {
                txt_id.Text = dataGridView1.SelectedCells[0].Value.ToString();
                Nomfolleto.Text = dataGridView1.SelectedCells[1].Value.ToString();
                Autor.Text = dataGridView1.SelectedCells[2].Value.ToString();
                txt_clave.Text = dataGridView1.SelectedCells[3].Value.ToString();
                txt_ubi.Text = dataGridView1.SelectedCells[4].Value.ToString();
                txt_des.Text = dataGridView1.SelectedCells[5].Value.ToString();
               
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }


        }

        private void btt_elim_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Desea eliminar?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            int id = Convert.ToInt32(txt_id.Text);


            if (confirmar == DialogResult.OK)
            {
                
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

            } else
            {
                Limpiar();
            }
        }

        private void btt_Modificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string nombre = Nomfolleto.Text;
            string autor = Autor.Text;
            string clave = txt_clave.Text;
            string ubicacion = txt_ubi.Text;
            string descripcion = txt_des.Text;

            DialogResult confirmar = MessageBox.Show("¿Desea realizar los cambios?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmar == DialogResult.OK) {
                Libros libro = new Libros(id, nombre, autor, clave, ubicacion, descripcion);
                int fila = libro.EditarLibros();

                if (fila == 1)
                {
                    MessageBox.Show("Se realizaron los cambios");
                    Limpiar();
                    ListarLibros();
                } else
                {
                    MessageBox.Show("No se pudo actualizar");
                }
               
            } else
            {

                Limpiar();
            }

        }

        private void Limpiar()
        {
            Nomfolleto.Clear();
            Autor.Clear();
            txt_clave.Clear();
            txt_ubi.Clear();
            txt_des.Clear();

        }

       
    }
}
