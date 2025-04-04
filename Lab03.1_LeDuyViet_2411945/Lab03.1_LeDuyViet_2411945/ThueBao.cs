using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._1_LeDuyViet_2411945
{
    enum GioiTinh
    {
        Nam, Nu
    }
    internal class ThueBao
    {
        string diaChi;
        GioiTinh gioiTinh;
        public string hoTen;
        DateTime ngaySinh;
        string soDT;
        public string soCMND;

        public ThueBao()
        { 
        }

        public ThueBao(string diaChi, GioiTinh gioiTinh, string hoTen, DateTime ngaySinh, string soDT, string soCMND)
        {
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.soDT = soDT;
            this.soCMND = soCMND;
        }

        public ThueBao(string tb)
        {
            string[] s = tb.Split(',');
            soCMND = s[0];
            hoTen = s[1];
            ngaySinh = DateTime.Parse(s[2]);
            gioiTinh = (GioiTinh)(s[3] == "Nam" ? 0:1);
            soDT = s[4];
            diaChi = s[5];
        }

        /// <summary>
        ///  Thuộc tính chỉ đọc ThanhPho, trích xuất Thành phố từ diaChi
        /// </summary>
        public string ThanhPho
        {
            get
            {
                int vt = diaChi.LastIndexOf("-");                           //lưu Vị trí xuất hiện cuối cùng của dấu '-' vào vt
                return diaChi.Substring(vt + 1, diaChi.Length - 1 - vt);    //Lấy một phần của diaChi từ dấu '-' đến hết chuỗi
            }
        }


        public override string ToString()
        {
            return string.Format("{0, -6} {1, -12} {2,25} {3, -5} {4, -8} {5,-20}", soCMND, hoTen, ngaySinh, gioiTinh == GioiTinh.Nam ? "Nam" : "Nu", soDT, diaChi);
        }
    }
}
