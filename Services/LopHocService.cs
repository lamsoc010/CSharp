using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WinformApp.Models;

namespace WinformApp.Services
{
    public class LopHocService
    {
        public static List<LopHoc> GetFakeData()
        {
            List<LopHoc> listLopHoc = new List<LopHoc>();
            listLopHoc.Add(new LopHoc { maLopHoc = 1, tenLopHoc = "CNTTK18A" });
            listLopHoc.Add(new LopHoc { maLopHoc = 2, tenLopHoc = "CNTTK18B" });
            listLopHoc.Add(new LopHoc { maLopHoc = 3, tenLopHoc = "CNTTK18C" });
            return listLopHoc;
        }

        public static List<LopHoc> readFile(String path)
        {
            if (File.Exists(path))
            {
                var data = File.ReadAllText(path);
                var listLopHoc = JsonConvert.DeserializeObject<List<LopHoc>>(data);
                return listLopHoc;

            }
            else
            {
                File.Create(path);
                return null;
            }
        }
    }
}
