using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.Models
{
    public class SinhVien
    {
        public int id { get; set; }
        public string maSinhVien { get; set; }
        public string ho { get; set; }
        public string ten { get; set; }
        public string hoVaTen {
            get
            {
                return $"{ho} {ten}";
            }
        }
        public GIOITINH gioiTinh { get; set; }

        public string gioiTinhStr
        {
            get
            {
                if (gioiTinh == GIOITINH.Nam)
                    return "Nam";
                else if (gioiTinh == GIOITINH.Nu)
                    return "Nữ";
                else
                    return "Khác";
            }
        }

        public DateTime ngaySinh { get; set; }

        public string queQuan { get; set; }

        public int maLopHoc { get; set; }

        public enum GIOITINH
        {
            Nam, Nu, Khac
        }
    }
}
