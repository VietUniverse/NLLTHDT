using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2411945_LeDuyViet_Lab3
{
    internal class SinhVien
    {
        public string maSV;
        public string hoTen;
        public float dTB;
        public Boolean gioiTinh;
        private string lop;

        /// <summary>
        /// Phương thức định nghĩa property
        /// Dùng để truy cập và cập nhật biến lop
        /// </summary>
        public string Lop
        {
            //Sử dụng đế lấy giá trị của biến lop
            get { return lop; } //Trả về giá trị hiện tại của biến lop
            //Sử dụng để gán giá trị cho biến lớp
            set { lop = value.Trim(); } //Gán giá trị cho biến lop, xóa bỏ khoảng trắng ở đầu và cuối chuỗi
        }

        /// <summary>
        /// Phương thức tạo lập mặc định của lớp sinh viên
        /// Không có tham số
        /// </summary>

        public SinhVien()
        {
            //Gán chuỗi 1 cho thuộc tính maSV
            maSV = "1";
            //Gán giá trị chuỗi a cho thuộc tính hoTen
            hoTen = "a";
        }

        /// <summary>
        /// Sử dụng constructor để khởi tạo đối tượng của lớp SinhVien
        /// Với các giá trị ban đầu cho các thuộc tính
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="ho"></param>
        /// <param name="dtb"></param>
        /// <param name="gt"></param>
        /// <param name="lop"></param>

        public SinhVien(string ma, string ho, float dtb, bool gt, string lop)
        {
            //Gán giá trị tham số cho các biến thành viên (thuộc tính) của lớp SinhVien
            maSV = ma;
            hoTen = ho;
            dTB = dtb;
            gioiTinh = gt;
            this.lop = lop; //Để phân biệt giữa biến thành viên và tham số khi chúng trùng tên.
        }

        /// <summary>
        /// Constructor khởi tạo đối tượng SinhVien 
        /// Phân tách chuỗi line thành các phần tử riêng lẻ rồi gán cho các thuộc tính của đối tượng
        /// </summary>
        /// <param name="line"></param>
        public SinhVien(string line)
        {
            //001, Nguyen Van A, 8.0, Nam, CTK43 
            string[] str = line.Split(','); //Phân tách chuỗi thành danh sách chuỗi bằng ','
            maSV = str[0]; //Gán giá trị cho thuộc tính
            hoTen = str[1];
            dTB = float.Parse(str[2]);
            gioiTinh = str[3] == "Nam" ? true : false; //Nếu là nam thì là true còn nếu là nữ sẽ là false
            lop = str[4];
        }

        /// <summary>
        /// Phương thức này được sử dụng để tùy chỉnh cách hiển thị thông tin của đối tượng SinhVien khi gọi ToString() trên đối tượng đó.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //Định dạng chuỗi
            return string.Format("{0, 2} {1, 10} {2,5} {3, 6} {4, 10}", maSV, hoTen, dTB, gioiTinh == true ? "Nam" : "Nu", lop);
        } 

    }
}
