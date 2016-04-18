using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareTrack
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void bttnAdministrator_Click(object sender, EventArgs e)
        {
            AdministratorWindow AdminWindow = new AdministratorWindow();
            AdminWindow.Show();
        }

        private void bttnPacijenti_Click(object sender, EventArgs e)
        {
            PatientWindow PatientWindow = new PatientWindow();
            PatientWindow.Show();
        }

        private void bttnPomoć_Click(object sender, EventArgs e)
        {
            SupportWindow SuppWindow = new SupportWindow();
            SuppWindow.Show();
        }

        private void bttnLogOut_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
