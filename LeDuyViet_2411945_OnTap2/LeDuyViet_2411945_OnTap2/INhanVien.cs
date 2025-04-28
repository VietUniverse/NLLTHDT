using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap2
{
    internal interface INhanVien
    {
        int NhanVienID { get;set;}
        string Phong {  get; set;}

        float Luong {  get; set;}

        public string LayThongTinChiTiet();
    }
}
