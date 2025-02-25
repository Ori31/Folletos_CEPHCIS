using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFolletosCEPHCIS
{
    public partial class GuestMainPage : Form
    {
        public GuestMainPage()
        {
            InitializeComponent();
        }

        public bool IsUserGoingBack = false;

        private void BackButton_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;

            MainPage mainForm = new MainPage();
            mainForm.Show();
            this.Close();
        }

        private void GuestMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserGoingBack == false)
            {
                Application.Exit();
            }
        }

        private void SearchPageButton_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;

            GuestSearchPage guestSearchPage = new GuestSearchPage();
            guestSearchPage.Show();
            this.Close();
        }

        private void Folleto1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void Description1_Click(object sender, EventArgs e)
        {
            
         
        }

        private void GuestMainPage_Load(object sender, EventArgs e)
        {
            Libros libros = new Libros();

            string descripcion = libros.Des1();
            Description1.Text = descripcion;

            string titulo = libros.T1();
            TitleText1.Text = titulo;

            string titulo2 = libros.T2();
            TitleText2.Text = titulo2;

            string des= libros.Des2();
            Description2.Text = des;

            label21.Text = TitleText1.Text;
            label1.Text = TitleText2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;
            string Busqueda = TitleText1.Text;

            InfoPage infoPage = new InfoPage()
            {

                Busqueda = Busqueda
            };
            infoPage.Show();

            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

            IsUserGoingBack = true;
            string Busqueda = TitleText2.Text;

            InfoPage infoPage = new InfoPage()
            {
                Busqueda = Busqueda
            };

            infoPage.Show();
            this.Close();
        }
    }
}
