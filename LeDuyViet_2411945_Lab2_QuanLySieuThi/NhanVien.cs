using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLySieuThi
{
    internal class NhanVien
    {
        public string Area;
        public string Id;
        public string Name;
        public DateTime Birthday;
        public string Address;
        public string PhoneNumber;
        public string StartDate;
        public string IdCard;
        public NhanVien(string area, string id, string name, DateTime birthday, string address, string phoneNumber, string startDate, string idCard)
        {
            Area = area;
            Id = id;
            Name = name;
            Birthday = birthday;
            Address = address;
            PhoneNumber = phoneNumber;
            StartDate = startDate;
            IdCard = idCard;
        }
    }
}
