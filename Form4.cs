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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = Nomfolleto.Text;
            string autor = Autor.Text;
            string clave = txt_clave.Text;
            string ubicacion = txt_ubi.Text;
            string descripcion = txt_des.Text;
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
           

        }
        private void Limpiar()
        {
            Nomfolleto.Text = "";
            Autor.Text = "";
            txt_clave.Text = "";
            txt_ubi.Text = "";
            txt_des.Text = "";

        }
      
    }
}
