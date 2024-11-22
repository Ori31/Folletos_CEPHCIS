using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Datos;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {

        DataTable tabla;
        Usuario dato = new Usuario();
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
            Guardar();
            Iniciar();
            MessageBox.Show("Se ha guardado correctamente");
            Limpiar();

        }
        private void Guardar()
        {
            Librosmodel modelo = new Librosmodel()
            {
                Nombre = Nomfolleto.Text ,
                Autor = Autor.Text
            };
            dato.Guardar(modelo);
        }
        private void Limpiar()
        {
            Nomfolleto.Text = "";
            Autor.Text = "";
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Autor");

        }
    }
}
