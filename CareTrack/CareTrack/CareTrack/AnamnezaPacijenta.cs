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
    public partial class AnamnezaPacijenta : Form
    {
        public AnamnezaPacijenta()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void bttnDodajSlikuRane1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FolderZaSlikuRane = new OpenFileDialog();
            if (FolderZaSlikuRane.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                picBoxSlakaRane1.ImageLocation = FolderZaSlikuRane.FileName;
                picBoxSlakaRane1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void bttnDodajSlikuRane2_Click(object sender, EventArgs e)
        {
            OpenFileDialog FolderZaSlikuRane2 = new OpenFileDialog();
            if (FolderZaSlikuRane2.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                picBoxSlikaRane2.ImageLocation = FolderZaSlikuRane2.FileName;
                picBoxSlikaRane2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
