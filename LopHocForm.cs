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
    public partial class LopHocForm : Form
    {
        List<LopHoc> listLopHoc = new List<LopHoc>();
        string pathFileLopHoc;
        public LopHocForm()
        {
            InitializeComponent();
            pathFileLopHoc = Path.Combine(Application.StartupPath, "lophoc.txt");
            listLopHoc = LopHocService.readFile(pathFileLopHoc);
            napDuLieu();
        }

        public void napDuLieu()
        {
            listLopHoc = LopHocService.readFile(pathFileLopHoc);
            dgvLopHoc.DataSource = listLopHoc;
            int tongSoSinhVien = 0;
            foreach(var lh in listLopHoc)
            {
                tongSoSinhVien += lh.soSinhVien;
            }
            lbSoSinhVien.Text = tongSoSinhVien.ToString();

        }

        void ghiFile(List<LopHoc> listLopHoc)
        {
            var data = JsonConvert.SerializeObject(listLopHoc);
            File.WriteAllText(pathFileLopHoc, data);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int idIndentity;
            if (listLopHoc.Count == 0)
            {
                idIndentity = 1;
            } else
            {
                idIndentity = listLopHoc[listLopHoc.Count - 1].maLopHoc + 1;
            }
             
            
            var themLopHoc = new ThemLopHocForm(idIndentity);
            if (themLopHoc.ShowDialog() == DialogResult.OK)
            {
                if (listLopHoc == null)
                {
                    listLopHoc = new List<LopHoc>();
                }
                listLopHoc.Add(themLopHoc.lopHoc);
                MessageBox.Show(listLopHoc.Count.ToString());
                ghiFile(listLopHoc);
                napDuLieu();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Bạn có chắc là muốn xoá không?", "Chú ý",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK)
                {
                    var lopHoc = dgvLopHoc.SelectedRows[0].DataBoundItem as LopHoc;
                    if (lopHoc != null)
                    {
                        var _lh = listLopHoc.Where(lh => lh.maLopHoc == lopHoc.maLopHoc).FirstOrDefault();
                        if (_lh != null && _lh.soSinhVien == 0)
                        {
                            listLopHoc.Remove(_lh);
                            ghiFile(listLopHoc);
                            napDuLieu();
                            MessageBox.Show("Xoá lớp học thành công", "Thông báo",
                                MessageBoxButtons.OK);
                        } else
                        {
                            MessageBox.Show("Lớp học còn sinh viên không thể xoá", "Thông báo",
                                MessageBoxButtons.OK);
                        }
                    }
                }

            }
        }

        private void dgvLopHoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }
    }
}
