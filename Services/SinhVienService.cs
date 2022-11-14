using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WinformApp.Models;

namespace WinformApp.Services
{
    public class SinhVienService
    {
        public static List<SinhVien> fakeSinhVien()
        {
            Random random = new Random();
            var listSinhVien = new List<SinhVien>();
            var listLop = LopHocService.GetFakeData();
            foreach(var lop in listLop)
            {
                for(var i = 1; i <= 10; i++)
                {
                    SinhVien sinhVien = new SinhVien
                    {
                        id = lop.maLopHoc * 10 + i,
                        maSinhVien = $"IT{lop.maLopHoc*10 + i}",
                        ho = "Tran",
                        ten = $"Vinh Lam {lop.maLopHoc*10 + i}",
                        gioiTinh = (SinhVien.GIOITINH)random.Next(0,2),
                        ngaySinh = new DateTime(1999,08,24),
                        queQuan = "Huế",
                        maLopHoc = lop.maLopHoc
                    };
                    listSinhVien.Add(sinhVien);
                }
            }
            return listSinhVien;
        }

        public static List<SinhVien> readFile(String path)
        {
            if (File.Exists(path))
            {
                var data = File.ReadAllText(path);
                var listSinhVien = JsonConvert.DeserializeObject<List<SinhVien>>(data);
                return listSinhVien;

            }
            else
            {
                File.Create(path);
                return null;
            }
            //var data = File.ReadAllText(path);
            //var listSinhVien = JsonConvert.DeserializeObject<List<SinhVien>>(data);
            //return listSinhVien;
        }

        public static List<SinhVien> getSinhVienByMaLopHoc(List<SinhVien> listSinhVien, int maLopHoc) 
        {
            
            return listSinhVien.Where(sv => sv.maLopHoc == maLopHoc).ToList();
        }

        public static List<SinhVien> timKiemSinhVien(List<SinhVien> listSinhVien, int maLopHoc, string keyword)
        {
            return listSinhVien.Where(sv => sv.maLopHoc == maLopHoc && (sv.hoVaTen.Contains(keyword) || sv.maSinhVien.Contains(keyword))).ToList();
        }

        public static void updateSinhVien(List<SinhVien> listSinhVien, SinhVien sinhVien)
        {
            foreach(var sv in listSinhVien)
            {
                if(sv.maSinhVien == sinhVien.maSinhVien)
                {
                    sv.ho = sinhVien.ho;
                    sv.ten = sinhVien.ten;
                    sv.gioiTinh = sinhVien.gioiTinh;
                    sv.ngaySinh = sinhVien.ngaySinh;
                    sv.queQuan = sinhVien.queQuan;
                    sv.maLopHoc = sinhVien.maLopHoc;
                }
            }
        }
    }
}
