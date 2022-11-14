using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WinformApp.Models;
using WinformApp.Services;

namespace WinformApp
{
    public partial class QLSVForm : Form
    {
        List<LopHoc> listLopHoc = new List<LopHoc>();
        List<SinhVien> listSinhVien = new List<SinhVien>();
        string pathFileSinhVien;
        string pathFileLopHoc;
        public QLSVForm()
        {
            InitializeComponent();
            pathFileSinhVien = Path.Combine(Application.StartupPath, "sinhvien.txt");
            pathFileLopHoc = Path.Combine(Application.StartupPath, "lophoc.txt");
            listLopHoc = LopHocService.readFile(pathFileLopHoc);
            listSinhVien = SinhVienService.readFile(pathFileSinhVien);
            NapDanhSachLopHoc(listLopHoc);
        }

        void NapDanhSachLopHoc(List<LopHoc> listLopHoc)
        {
            cbbLopHoc.DataSource = listLopHoc;
            cbbLopHoc.DisplayMember = "tenLopHoc";
        }

        void NapDanhSachSinhVien(List<SinhVien> listSinhVien, int maLopHoc)
        {
            List<SinhVien> listSinhVienByMaLopHoc = SinhVienService.getSinhVienByMaLopHoc(listSinhVien, maLopHoc);
            sinhVienBindingSource.DataSource = listSinhVienByMaLopHoc;
            dgvSinhVien.DataSource = sinhVienBindingSource;
            lbSoSinhVien.Text = listSinhVienByMaLopHoc.Count.ToString();

        }

        void ghiFile(List<SinhVien> listSinhVien, List<LopHoc> listLopHoc) 
        {
            var dataSinhVien = JsonConvert.SerializeObject(listSinhVien);
            File.WriteAllText(pathFileSinhVien, dataSinhVien);

            var dataLopHoc = JsonConvert.SerializeObject(listLopHoc);
            File.WriteAllText(pathFileLopHoc, dataLopHoc);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lopHocModel = cbbLopHoc.SelectedItem as LopHoc;
            NapDanhSachSinhVien(listSinhVien, lopHocModel.maLopHoc);
        }

        private void tbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<SinhVien> listSinhVienSearch = new List<SinhVien>();
            if(e.KeyChar == 13)
            {
                var lopHocModel = cbbLopHoc.SelectedItem as LopHoc;
                listSinhVienSearch = SinhVienService.timKiemSinhVien(listSinhVien,lopHocModel.maLopHoc, tbTimKiem.Text);
                NapDanhSachSinhVien(listSinhVienSearch, lopHocModel.maLopHoc);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            //int id = listSinhVien.;
            //int maLopHoc = listSinhVien[listSinhVien.Count].maLopHoc;
            var themSinhVienForm = new ThemSinhVien(null, listSinhVien, LopHocService.readFile(pathFileLopHoc));
            if(themSinhVienForm.ShowDialog() == DialogResult.OK)
            {
                if(listSinhVien == null)
                {
                    listSinhVien = new List<SinhVien>();
                }
                listSinhVien.Add(themSinhVienForm.sinhVien);
                //MessageBox.Show("Them sinh vien " + themSinhVienForm.sinhVienAdd.hoVaTen);
                //Xét lại số lượng sinh viên trong lớp
                var _lh = listLopHoc.Where(lh => lh.maLopHoc == themSinhVienForm.sinhVien.maLopHoc).FirstOrDefault();
                _lh.soSinhVien += 1;
                ghiFile(listSinhVien, listLopHoc);

                NapDanhSachSinhVien(listSinhVien, themSinhVienForm.sinhVien.maLopHoc);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sinhVienCu = dgvSinhVien.SelectedRows[0].DataBoundItem as SinhVien;
            var suaSinhVienForm = new ThemSinhVien(sinhVienCu, listSinhVien, LopHocService.readFile(pathFileLopHoc));
            if(suaSinhVienForm.ShowDialog() == DialogResult.OK)
            {
                var sinhVienMoi = suaSinhVienForm.sinhVien;
                //Cập nhập lại số lượng sinh viên ở lớp học
                if (sinhVienCu.maLopHoc != sinhVienMoi.maLopHoc)
                {
                    foreach (var lh in listLopHoc)
                    {
                        if (lh.maLopHoc == sinhVienCu.maLopHoc)
                        {
                            lh.soSinhVien -= 1;
                        }
                        if (lh.maLopHoc == sinhVienMoi.maLopHoc)
                        {
                            lh.soSinhVien += 1;

                        }
                    }

                }
                SinhVienService.updateSinhVien(listSinhVien, sinhVienMoi);
                ghiFile(listSinhVien, listLopHoc);
                //NapDanhSachSinhVien(listSinhVien, sinhVienMoi.maLopHoc);
                MessageBox.Show(sinhVienMoi.maLopHoc.ToString());
                cbbLopHoc.SelectedIndex = listLopHoc.FindIndex(x => x.maLopHoc == sinhVienMoi.maLopHoc);
                MessageBox.Show("Sửa sinh viên thành công");
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvSinhVien.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Bạn có chắc là muốn xoá không?", "Chú ý",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(confirm == DialogResult.OK)
                {
                    var sinhVien = dgvSinhVien.SelectedRows[0].DataBoundItem as SinhVien;
                    if (sinhVien != null)
                    {
                        var _sv = listSinhVien.Where(sv => sv.maSinhVien == sinhVien.maSinhVien).FirstOrDefault();
                        if (_sv != null)
                        {
                            listSinhVien.Remove(_sv);
                            MessageBox.Show("Xoá sinh viên thành công", "Thông báo",
                                MessageBoxButtons.OK);
                            //Giảm số sinh viên
                            var _lh = listLopHoc.Where(lh => lh.maLopHoc == sinhVien.maLopHoc).FirstOrDefault();
                            _lh.soSinhVien -= 1;
                            NapDanhSachSinhVien(listSinhVien, sinhVien.maLopHoc);
                            ghiFile(listSinhVien, listLopHoc);
                        }
                    }
                }
                
            }
        }

        private void llbDanhSachLopHoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var lopHocForm = new LopHocForm();
            if(lopHocForm.ShowDialog() == DialogResult.Cancel)
            {
                NapDanhSachLopHoc(LopHocService.readFile(pathFileLopHoc));
            }
        }
    }
}
