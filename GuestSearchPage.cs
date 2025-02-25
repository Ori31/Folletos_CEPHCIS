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
    public partial class GuestSearchPage : Form
    {
        public GuestSearchPage()
        {
            InitializeComponent();
        }

        public bool IsUserGoingBack = false;

        private void BackButton_Click(object sender, EventArgs e)
        {
            IsUserGoingBack=true;
            
            GuestMainPage guestMainPage = new GuestMainPage();
            guestMainPage.Show();
            this.Close();
            
        }

        private void GuestSearchPage_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Folleto1_Click(object sender, EventArgs e)
        {
           
        }

        private void Folleto2_Click(object sender, EventArgs e)
        {
          
        }

        private void Folleto3_Click(object sender, EventArgs e)
        {
           
        }

        private void Folleto4_Click(object sender, EventArgs e)
        {
            
        }

        private void Folleto5_Click(object sender, EventArgs e)
        {
            string Busqueda = label11.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void Folleto6_Click(object sender, EventArgs e)
        {
           
        }

        private void Folleto7_Click(object sender, EventArgs e)
        {
          
        }

        private void Folleto8_Click(object sender, EventArgs e)
        {
           
        }

        private void Folleto9_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GuestSearchPage_Load(object sender, EventArgs e)
        {

            //Los titulos y autores de cada recuadro
            Libros libros = new Libros();
            string titulo = libros.T1();
            label1.Text = titulo;

            string titulo2 = libros.T2();
            label3.Text = titulo2;

            string autor1 = libros.Autor1();
            AutorText1.Text = autor1;


            string autor2 = libros.Autor2();
            label2.Text = autor2;

            string titulo3 = libros.T3(); 
            label5.Text = titulo3;

            string autor3 = libros.Autor3(); 
            label4.Text = autor3;

            string titulo4 = libros.T4();
            label15.Text = titulo4;

            string autor4 = libros.Autor4();
            label14.Text = autor4;

            string titulo5 = libros.T5();
            label11.Text = titulo5;

            string autor5 = libros.Autor5();
            label10.Text = titulo5;

            string titulo6 = libros.T6();
            label7.Text = titulo6;

            string autor6 = libros.Autor6();
            label6.Text = autor6;

            string titulo7 = libros.T7();
            label17.Text = titulo7;

            string autor7 = libros.Autor7();
            label16.Text = autor7;

            string titulo8 = libros.T8();
            label13.Text = titulo8;

            string autor8 = libros.Autor8();
            label12.Text = autor8;

            string titulo9 = libros.T9();
            label9.Text = titulo9;

            string autor9 = libros.Autor9();
            label8.Text = autor9;

            //Los titulos en las fotos
            label18.Text = label1.Text;
            label19.Text = titulo2;
            label20.Text = titulo3;
            label21.Text = titulo4;
            label22.Text = titulo5;
            label23.Text = titulo6;
            label24.Text = titulo7;
            label25.Text = titulo8;
            label26.Text = titulo9;
            
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SearchIcon_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string busqueda = "%" + SearchBox.Text + "%";
            Libros libros = new Libros(busqueda);
            string Busqueda = libros.p1();

            label1.Text = Busqueda;
            label18.Text = Busqueda;

            string autor = libros.a2();
            AutorText1.Text = autor;

            
        }

        private void label18_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;

            string Busqueda = label1.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;

            string Busqueda = label3.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            string Busqueda = label5.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            string Busqueda = label15.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            string Busqueda = label11.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            string Busqueda = label7.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            string Busqueda = label17.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            string Busqueda = label13.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            string Busqueda = label9.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();
            this.Close();
        }
    }
    
}
