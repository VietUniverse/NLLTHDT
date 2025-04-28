using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap2
{
    internal interface INguoi
    {
        public string Ho {  get; set; }
        public string Ten { get; set; }

        public string LayTenDayDu();
    }
}
