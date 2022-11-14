using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
            cmbCheDo.SelectedIndex = 2;
        }

        

        private void cmbCheDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbCheDo.SelectedIndex;
            switch(index)
            {
                case 0:
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 1:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
            }
        }

        private void btnXoayTrai_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
            //pictureBox1.Left += 90;
        }

        private void btnXoayPhai_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }


        private void btnLatDoc_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }

        private void btnLatNgang_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }

        private void lnkChonFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = false,
                ValidateNames = true,
                Filter = "JPEG|*.jpg|"
            };
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
            

        }
    }
}
