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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        public bool IsUserChangingScreen = false;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserChangingScreen == false)
            {
                Application.Exit();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            IsUserChangingScreen = true;
            MainPage MainForm = new MainPage();
            MainForm.Show();

            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            IsUserChangingScreen = true;
            AddPage addPage = new AddPage();
            addPage.Show();
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            IsUserChangingScreen = true;
            EditPage editPage = new EditPage(); 
            editPage.Show();
            this.Close();
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            IsUserChangingScreen = true;
            StatsPage statsPage = new StatsPage();
            statsPage.Show();
            this.Close();
        }
    }
}
