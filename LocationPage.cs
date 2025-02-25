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
    public partial class LocationPage : Form
    {
        public LocationPage()
        {
            InitializeComponent();
        }

        public bool IsUserGoingBack = false;
        private void LocationPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserGoingBack == false)
            {
                Application.Exit();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            IsUserGoingBack = true;
            GuestSearchPage infoPage = new GuestSearchPage();
            infoPage.Show();
            this.Close();
        }

        private void NameText_Click(object sender, EventArgs e)
        {

        }
        public string Busqueda { get; set; }

        private void LocationPage_Load(object sender, EventArgs e)
        {
            Libros libros = new Libros(Busqueda);
            label1.Text = libros.Ubi();
            NameText.Text = libros.Nom();
            
        }
    }
}
