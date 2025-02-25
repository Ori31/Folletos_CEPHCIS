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
    public partial class StatsPage : Form
    {
        public StatsPage()
        {
            InitializeComponent();
        }

        public bool IsUserChangingScreen = false;
        private void BackButton_Click(object sender, EventArgs e)
        {
            IsUserChangingScreen = true;
            
            AdminMainPage adminMainPage = new AdminMainPage();
            adminMainPage.Show();
            this.Close();
        }

        private void StatsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsUserChangingScreen == false)
            {
                Application.Exit();
            }
        }
    }
}
