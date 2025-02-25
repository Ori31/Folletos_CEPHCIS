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
    public partial class InfoPage : Form
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        public bool IsUserGoingBack = false;

        private void InfoPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserGoingBack == false)
            {
                Application.Exit();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;
            GuestSearchPage guestSearchPage = new GuestSearchPage();
            guestSearchPage.Show();
            this.Close();

        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;

            string Busqueda = NameText.Text;

            LocationPage locationPage = new LocationPage()
            {

                Busqueda = Busqueda
            };
            locationPage.Show();
            this.Close();

           
        }

        private void VirtualButton_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;

            string Busqueda = NameText.Text;

            VirtualPage virtualPage = new VirtualPage()
            {

                Busqueda = Busqueda
            };
          
         
            virtualPage.Show();
            this.Close();
        }

        private void InfoPage_Load(object sender, EventArgs e)
        {
            Libros libros = new Libros(Busqueda);
            label1.Text = libros.Des();
            NameText.Text = libros.Nom();
            AutorText.Text = libros.Au();
            KeywordText.Text = libros.Cla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string Busqueda { get; set; }

        private void NameText_Click(object sender, EventArgs e)
        {

        }
    }
}
