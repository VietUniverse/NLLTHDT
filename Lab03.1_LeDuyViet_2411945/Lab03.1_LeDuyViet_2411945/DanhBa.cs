using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._1_LeDuyViet_2411945
{
    internal class DanhBa
    {
        List<ThueBao> thueBaos = new List<ThueBao>();
        public void Xuat()
        {
            foreach (var i in thueBaos)
            {
                //i.ToString();
                Console.WriteLine(i.ToString());
            }
        }
        public void Them(ThueBao thueBao)
        {
            thueBaos.Add(thueBao);
        }

        /// <summary>
        /// Lấy dữ liệu từ file csv và đưa các thuê bao vào mảng thuê bao
        /// </summary>

        public void NhapTuFile()
        {
            string root = "data.csv";                   //Nhap ten file
            StreamReader sr = new StreamReader(root);   //Mo tap tin len va đọc nội dung
            string s = "";                              //Khai báo chuỗi rỗng dùng để nhập từng dòng trong file
            while ((s = sr.ReadLine()) != null)          //Vòng lặp để đọc từng dòng và gán nó cho chuỗi s, nếu chuỗi rỗng (hết dữ liệu) thì dừng
            {
                ThueBao n = new ThueBao(s);             //Gán thuê bao s mới cho n
                thueBaos.Add(n);                        //Thêm thuê bao mới đó vào mảng ThueBao
            }
        }

        /// <summary>
        /// Lấy danh sách các thành phố
        /// </summary>
        /// <returns>Danh sách các thành phố</returns>

        public List<string> TimDSCacThanhPho()
        {
            List<string> list = new List<string>();     //Khai báo mảng lưu các thành phố
            foreach (var i in thueBaos)                 //Vòng lặp duyệt qua mảng chứa các thuê bao
            {
                if (!list.Contains(i.ThanhPho))         //Kiểm tra nếu thành phố đó không nằm trong mảng lưu các thành phố
                {
                    list.Add(i.ThanhPho);               //Thêm thành phố vào mảng
                }
            }
            return list;                                //Trả về mảng gồm danh sách các thành phố
        }

        /// <summary>
        /// Đếm các thuê bao của một thành phố
        /// </summary>
        /// <param name="tp">Tên thành phố cần đếm</param>
        /// <returns>Số thuê bao của thành phố đó</returns>

        public int DemSoThueBaoTheoTP(string tp)
        {
            int dem = 0;                //Khai báo biến đếm
            foreach (var i in thueBaos)  //Vòng lặp duyệt qua mảng chứa các thuê bao
            {
                if (i.ThanhPho == tp)   //Nếu thành phố của thuê bao trùng với thành phố đang cần đếm
                    dem++;              //Tăng biến đếm lên 1
            }
            return dem;                 //Trả về số thuê bao của thành phố đó
        }

        /// <summary>
        /// Tìm thành phố có nhiều thuê bao nhất
        /// </summary>
        /// <returns>Danh sáchtên thành phố</returns>

        public List<string> TimTPCoNhieuThueBaoNhat()
        {
            List<string> kq = new List<string>();       //Khai báo mảng chứa tên các thành phố có nhiều thuê bao nhất
            List<string> dstp = TimDSCacThanhPho();     //Khai báo danh sách chứa tên các thành phố
            int max = int.MinValue;                     //Khai báo biến max là số thuê bao nhiều nhất của một thành phố
            foreach (var i in dstp)                     //Vòng lặp duyệt qua dstp
            {
                if (max < DemSoThueBaoTheoTP(i))        //Nếu max nhỏ hơn số thuê bao của thành phố đó
                    max = DemSoThueBaoTheoTP(i);        //Gán số thuê bao của thành phố đó cho max
            }

            foreach (var i in dstp)                     //Duyệt qua dstp
            {
                if (DemSoThueBaoTheoTP(i) == max)        //Nếu số thuê bao của thành phố đó = max
                    kq.Add(i);                          //Thêm tên tp đó vào mảng chứa tên các tp có nhiều thuê bao nhất
            }
            return kq;                                  //Trả về mảng gồm tên các thành phố có nhiều thuê bao nhất
        }

        public List<string> TimTPCoItThueBaoNhat()
        {
            List<string> kq = new List<string>();
            List<string> dstp = TimDSCacThanhPho();
            int min = int.MaxValue;
            foreach (var i in dstp)
            {
                if (min > DemSoThueBaoTheoTP(i))
                    min = DemSoThueBaoTheoTP(i);
            }

            foreach (var i in dstp)
            {
                if (DemSoThueBaoTheoTP(i) == min)
                    kq.Add(i);
            }
            return kq;
        }

        public List<string> TimDSCacThueBao()
        {
            List<string> list = new List<string>();
            foreach (var i in thueBaos)
            {
                if (!list.Contains(i.soCMND))
                {
                    list.Add(i.soCMND);
                }
            }
            return list;
        }

        public int DemSoCuaThueBao(string num)
        {
            int dem = 0;       
            foreach (var i in thueBaos)
            {
                if (i.soCMND == num)  
                    dem++;         
            }
            return dem;    
        }

        public List<string> TimThueBaoItSoDTNhat()
        {
            List<string> kq = new List<string>();
            List<string> dstp = TimDSCacThueBao();
            int min = int.MaxValue;
            foreach (var i in dstp)
            {
                if (min > DemSoCuaThueBao(i))
                    min = DemSoCuaThueBao(i);
            }

            foreach (var i in dstp)
            {
                if (DemSoCuaThueBao(i) == min)
                    kq.Add(i);
            }
            return kq;
        }

        public void SapXepTangTheoTen()
        {
            thueBaos = thueBaos.OrderBy(tb => tb.hoTen).ToList();
        }
        public void SapXepGiamTheoTen()
        {
            thueBaos = thueBaos.OrderByDescending(tb => tb.hoTen).ToList();
        }

    }
}
