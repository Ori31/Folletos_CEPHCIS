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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = txt_usuario.Text;
            string tex2 = txt_contra.Text;
            string usuario = "Administrador";
            string contrasena = "Admin123";
            if(usuario == text && contrasena == tex2)
            {
                MessageBox.Show("Iniciado correctamente", "inicio sesion" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
