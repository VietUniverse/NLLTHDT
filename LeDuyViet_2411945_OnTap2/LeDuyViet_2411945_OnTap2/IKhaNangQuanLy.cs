using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap2
{
    internal interface IKhaNangQuanLy
    {
        public string NhiemVu { get; set; }

        public void GanNhiemVu(string nhiemVu);
    }
}
