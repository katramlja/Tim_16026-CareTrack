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
    public partial class PatientWindow : Form
    {
        public PatientWindow()
        {
            InitializeComponent();
        }

        private void bttnAnamneza_Click(object sender, EventArgs e)
        {
            AnamnezaPacijenta AnamnezaPacijent = new AnamnezaPacijenta();
            AnamnezaPacijent.Show();
        }
    }
}
