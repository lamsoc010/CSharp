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
    public partial class OclockForm : Form
    {
        public OclockForm()
        {
            InitializeComponent();
        }
        public int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count -= 2;
            if(count == 0)
            {
                timer1.Stop();
                MessageBox.Show("Thời gian đã hết!");
            } else if(count == 10)
            {
                lblKetQua.ForeColor = Color.Red;
            }
            lblKetQua.Text = convert(count);
            
        }

 

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            lblKetQua.ForeColor = Color.Black;
            timer1.Start();
        }

       

        string convert(int second)
        {
            var p = second / 60;
            var s = second % 60;
            return Convert.ToString($"{p:0#}:{s:0#}");
        }

        private void btnDungLai_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SettingForm();
            if(f.ShowDialog() == DialogResult.OK)
            {
                count = f.Minutes * 60;
                lblKetQua.Text = convert(count);
            }
        }
    }
}
