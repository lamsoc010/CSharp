using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformApp.Models;

namespace WinformApp
{
    public partial class ThemLopHocForm : Form
    {
        public LopHoc lopHoc { get; private set; }
        public ThemLopHocForm(int id)
        {
            InitializeComponent();
            tbMaLopHoc.Text = id.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var maLopHoc = tbMaLopHoc.Text;
            var tenLopHoc = tbTenLopHoc.Text;

            lopHoc = new LopHoc
            {
                maLopHoc = Int32.Parse(maLopHoc),
                tenLopHoc = tenLopHoc,
                soSinhVien = 0
            };
            DialogResult = DialogResult.OK;
        }
    }
}
