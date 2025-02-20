using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLySieuThi
{
    internal class NhaCungCap
    {
        public string Id;
        public string Name;
        public string TaxCode;
        public string Address;
        public string PhoneNum;
        public string Email;
        public NhaCungCap(string id, string name, string taxCode, string address, string phoneNum, string email)
        {
            Id = id;
            Name = name;
            TaxCode = taxCode;
            Address = address;
            PhoneNum = phoneNum;
            Email = email;
        }
    }
}
