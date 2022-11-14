using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.WebSockets;

namespace WinformApp
{
    public partial class SliderShowForm : Form
    {
        public SliderShowForm()
        {
            InitializeComponent();
        }
        List<string> listImagePath;
        List<PictureBox> listPictureBox;
        int indexImage = 0;
        
        private void lnkChonThuMuc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                var folderName = dialog.SelectedPath;
                var listFile = Directory.GetFiles(folderName);
                for(var i = 0; i < listFile.Length; i++)
                {
                    if (isImage(listFile[i]))
                    {
                        if (listImagePath == null)
                            listImagePath = new List<string>();
                        listImagePath.Add(listFile[i]);


                        flpImage.Controls.Add(addPicturePanelToFlowPanel(listFile[i], i));

                        //if (listPictureBox == null)
                        //    listPictureBox = new List<PictureBox>();
                        //listPictureBox.Add(addPicturePanelToFlowPanel(listFile[i]));
                    }
                }
                //listPictureBox[indexImage].BorderStyle = BorderStyle.FixedSingle;
                pictureBox1.Image = Image.FromFile(listImagePath[indexImage]);
                
                timer1.Start();
            }
        }

        private void pictureBox_Clicked(object sender, EventArgs e)
        {
            var ptb = (PictureBox)sender;
            pictureBox1.Image = ptb.Image;
            for (int i = 0; i < flpImage.Controls.Count;i++)
            {
                var p =flpImage.Controls[i] as PictureBox;
                p.BorderStyle = BorderStyle.None;
            }
            ptb.BorderStyle = BorderStyle.FixedSingle;
            int index = flpImage.Controls.GetChildIndex(ptb);
            indexImage = index;


        }

        private PictureBox addPicturePanelToFlowPanel(String file, int index)
        {
            PictureBox ptb = new PictureBox();
            ptb.ImageLocation = file;
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb.Click += new EventHandler(pictureBox_Clicked);
            ptb.Name = "ptb" + index;
            return ptb;
        }

        bool isImage(string fileName)
        {
            try
            {
                Image image = Image.FromFile(fileName);
                return true;
            }catch
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(indexImage == listImagePath.Count -1 )
            {
                indexImage = 0;
            } else
            {
                indexImage++;
            }

            for (int i = 0; i < flpImage.Controls.Count; i++)
            {
                var p1 = flpImage.Controls[i] as PictureBox;
                p1.BorderStyle = BorderStyle.None;
            }
            var p = flpImage.Controls[indexImage] as PictureBox;
            p.BorderStyle = BorderStyle.FixedSingle;

            pictureBox1.Image = Image.FromFile(listImagePath[indexImage]);
        }
    }
}
