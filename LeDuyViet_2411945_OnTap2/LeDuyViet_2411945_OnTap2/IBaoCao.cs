using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap2
{
    internal interface IBaoCao
    {
        public string TienDo {  get; set; } 
        public void TaoBaoCao(string nv);
    }
}
