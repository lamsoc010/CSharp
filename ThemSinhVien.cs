using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using WinformApp.Models;
using WinformApp.Services;

namespace WinformApp
{
    public partial class ThemSinhVien : Form
    {
        public SinhVien sinhVien { get; private set; }
        List<SinhVien> listSinhVien;
        public ThemSinhVien(SinhVien? sinhVienCu, List<SinhVien>? listSinhVienAdd, List<LopHoc>? listLopHoc)
        {
            InitializeComponent();
            sinhVien = sinhVienCu;
            listSinhVien = listSinhVienAdd;
            if (sinhVien == null) //Chức năng thêm
            {
                btnSua.Enabled = false;
            } else //Chức năng sửa
            {
                btnThem.Enabled = false;
            }
            NapDuLieu(listLopHoc);
        }

        public void NapDuLieu(List<LopHoc> listLopHoc)
        {
            cbbMaLopHoc.DataSource = listLopHoc;
            cbbMaLopHoc.DisplayMember = "tenLopHoc";
            if (sinhVien != null)
            {
                
                tbMaSinhVien.Text = sinhVien.maSinhVien;
                tbMaSinhVien.Enabled = false;
                tbHo.Text = sinhVien.ho;
                tbTen.Text = sinhVien.ten;
                tbQueQuan.Text = sinhVien.queQuan;
                cbbMaLopHoc.SelectedIndex = listLopHoc.FindIndex(x => x.maLopHoc == sinhVien.maLopHoc);
                cbbGioiTinh.Text = sinhVien.gioiTinhStr;
            }

            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var lopHocModel = cbbMaLopHoc.SelectedItem as LopHoc;
            string maSinhVien = tbMaSinhVien.Text;
            string ho = tbHo.Text;
            string ten = tbTen.Text;
            string queQuan = tbQueQuan.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            int maLopHoc = lopHocModel.maLopHoc;
            int gioiTinh = cbbGioiTinh.SelectedIndex;

            sinhVien = new SinhVien
            {
                id = 100,
                maSinhVien = maSinhVien,
                ho = ho,
                ten = ten,
                gioiTinh = (SinhVien.GIOITINH)gioiTinh,
                ngaySinh = ngaySinh,
                queQuan = queQuan,
                maLopHoc = maLopHoc
            };
            DialogResult = DialogResult.OK;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var lopHocModel = cbbMaLopHoc.SelectedItem as LopHoc;
            DialogResult = DialogResult.OK;
            string maSinhVien = tbMaSinhVien.Text;
            string ho = tbHo.Text;
            string ten = tbTen.Text;
            string queQuan = tbQueQuan.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            int maLopHoc = lopHocModel.maLopHoc;

            int gioiTinh = cbbGioiTinh.SelectedIndex;

            sinhVien = new SinhVien
            {
                id = 100,
                maSinhVien = maSinhVien,
                ho = ho,
                ten = ten,
                gioiTinh = (SinhVien.GIOITINH)gioiTinh,
                ngaySinh = ngaySinh,
                queQuan = queQuan,
                maLopHoc = maLopHoc
            };
        }

        private void tbMaSinhVien_Leave(object sender, EventArgs e)
        {
            foreach(var sv in listSinhVien)
            {
                if(sv.maSinhVien.Equals(tbMaSinhVien.Text))
                {
                    MessageBox.Show("Mã sinh viên đã trùng, vui lòng nhập mã khác!");
                    tbMaSinhVien.Focus();
                }
            }
        }
    }
}
