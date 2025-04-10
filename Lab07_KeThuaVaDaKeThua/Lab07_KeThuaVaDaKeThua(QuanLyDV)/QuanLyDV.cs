using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_KeThuaVaDaKeThua_QuanLyDV_
{
    public class QuanLyDV
    {
        List<Animal> collection;

        public QuanLyDV()
        {
            collection = new List<Animal>();
        }
        public void Xuat()
        {
            foreach(var dv in collection)
                Console.WriteLine(dv);
            Console.WriteLine();
        }
        public void Them(Animal dv, int x)
        {
            collection.Insert(x,dv);
        }

        public void NhapTuFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string s = "";
            Animal animal;
            while ((s = sr.ReadLine()) != null)
            {
                var line = s.Split(',');
                var loai = line[0]; //tạo thêm 1 thuộc tính nữa là loài để chứa thông tin về loài động vật, dễ tính toán hơn
                var name = line[1];
                var age = int.Parse(line[2]);
                if (loai == "Lion")
                    animal = new Lion(loai, name, age);
                else if (loai == "Bird")
                    animal = new Bird(loai, name, age);
                else if (loai == "Bat")
                    animal = new Bat(loai, name, age);
                else if (loai == "Fish")
                    animal = new Fish(loai, name, age);
                else
                    animal = new Animal(loai, name, age);
                Them(animal, collection.Count);
            }
            sr.Close();
        }
        public void ThemDV(int vt)
        {
            Console.Write("Nhap theo cau truc: Loai,ten,tuoi: ");
            string s = Console.ReadLine();
            Animal animal;
            string[] line = s.Split(",");
            string loai = line[0];
            string name = line[1];
            var age = int.Parse(line[2]);
            if (loai == "Lion")
                animal = new Lion(loai, name, age);
            else if (loai == "Bird")
                animal = new Bird(loai, name, age);
            else if (loai == "Bat")
                animal = new Bat(loai, name, age);
            else if (loai == "Fish")
                animal = new Fish(loai, name, age);
            else
                animal = new Animal(loai, name, age);
            Them(animal,vt);
        }

        public int Counting()
        {
            return collection.Count;
        }

        public int DemSLDongVat(string name)
        {
            int count = 0;
            foreach (var item in collection)
                if (item.loai.Trim() == name)
                    count++;
            return count;
        }
        public void XuatDSSLDV()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                if (!kq.Contains(item.loai)) //để tránh lặp lại, tạo mảng phụ rồi add những con đã đếm vào mảng
                                             //nếu có trong mảng rồi thì không đếm nữa
                {
                    Console.WriteLine($"So luong dong vat la {item.loai} la: {DemSLDongVat(item.loai)}");
                    kq.Add(item.loai);
                }
            }
        }

        public void DemSLDVLaBat_Lion_Bird(string x)
        {
            int kq = 0;
            if (x == "Bat" || x == "bat")
            {
                //kq = DemSLBat();
                kq = DemSLDongVat("Bat");
                Console.WriteLine($"So luong dv la Bat la: {kq}");
            }
            else if (x == "Lion" || x == "lion")
            {
                //kq = DemSLLion();
                kq = DemSLDongVat("Lion");
                Console.WriteLine($"So luong dv la Lion la: {kq}");
            }
            else if (x == "Bird" || x == "bird")
            {
                //kq = DemSLBird();
                kq = DemSLDongVat("Bird");
                Console.WriteLine($"So luong dv la Bird la: {kq}");
            }
        }
        public List<string> DSDVBietBay()
        {
            List<string> kq = new List<string>();
            foreach(var item in collection)
                if (item is IFlyable && !kq.Contains(item.name))
                    kq.Add(item.name);
            return kq;
        }
        public List<string> DSDVKhongBietBay()
        {
            List<string> bietBay = DSDVBietBay();
            List<string> kq = new List<string>();
            foreach (var item in collection)
                if (!bietBay.Contains(item.name))
                    kq.Add(item.name);
            return kq;
        }
        public int DemSLDVBietBay()
        {
            List<string> bietBay = DSDVBietBay();
            int count = 0;
            foreach (var item in bietBay)
                count++;
            return count;
        }
        public int DemSLDVKhongBietBay()
        {
            List<string> khongBietBay = DSDVKhongBietBay();
            int count = 0;
            foreach (var item in khongBietBay)
                count++;
            return count;
        }
        public void DemSLDVBietBay_KhongBietBay()
        {
            Console.WriteLine($"SL dv biet bay la: {DemSLDVBietBay()}");
            Console.WriteLine($"SL dv khong biet bay la: {DemSLDVKhongBietBay()}");
        }

        //Dem sl dv khong biet bay theo ten, tuoi

        //Tim dv max, dv min
        public int TimDVCoSLMax()
        {
            int max = int.MinValue;
            foreach (var item in collection)
                if (max < DemSLDongVat(item.loai))
                    max = DemSLDongVat(item.loai);
            return max;
        }
        public int TimDVCoSLMin()
        {
            int min = int.MaxValue;
            foreach (var item in collection)
                if (min > DemSLDongVat(item.loai))
                    min = DemSLDongVat(item.loai);
            return min;
        }
        public void TimDVCoSLMax_Min()
        {
            List<string> ds = new List<string>();
            foreach (var item in collection)
                if (!ds.Contains(item.loai))
                {
                    if (DemSLDongVat(item.loai) == TimDVCoSLMax())
                    {
                        Console.WriteLine($"DV co sl nhieu nhat la: {item.loai}");
                        ds.Add(item.loai);
                    }
                    else if (DemSLDongVat(item.loai) == TimDVCoSLMin())
                    {
                        Console.WriteLine($"DV co sl it nhat la: {item.loai}");
                        ds.Add(item.loai);
                    }
                }
        }
        public List<string> TimDVThuocLoaiBat()
        {
            List<string>bat = new List<string>();
            foreach(var item in collection)
                if(item is Bat) //lọc trực tiếp dựa trên lớp của chúng
                    bat.Add(item.name);
            return bat;
        }
        public List<string> TimDVThuocLoaiBird()
        {
            List<string> bird = new List<string>();
            foreach (var item in collection)
                if (item is Bird)
                    bird.Add(item.name);
            return bird;
        }
        public List<string> TimDVThuocLoaiLion()
        {
            List<string> lion = new List<string>();
            foreach (var item in collection)
                if (item is Lion)
                    lion.Add(item.name);
            return lion;
        }
        public void XuatList(List<string>ds)
        {
            foreach (var item in ds)
                Console.Write(item + ", ");
            Console.WriteLine();
        }

        //Tim ten ngan nhat - dai nhat
        public int DemSoKyTu(string x)
        {
            return x.Replace(" ", "").Length; //length để đếm số kí tự, replace để loại bỏ khoảng trắng
        }

        public int TimMaxSoKyTu(List<Animal> ds)
        {
            int max = int.MinValue;
            foreach (var item in ds)
                if (max < DemSoKyTu(item.name))
                    max = DemSoKyTu(item.name);
            return max;
        }

        public int TimMinSoKyTu(List<Animal> ds)
        {
            int min = int.MaxValue;
            foreach (var item in ds)
                if (min > DemSoKyTu(item.name))
                    min = DemSoKyTu(item.name);
            return min;
        }

        public List<string> DSTenNganNhat()
        {
            List<string> dstenngan = new List<string>();
            foreach(var item in collection)
                if(DemSoKyTu(item.name) == TimMinSoKyTu(collection))
                    dstenngan.Add(item.name);
            return dstenngan;
        }
        public List<string> DSTenDaiNhat()
        {
            List<string> dstendai = new List<string>();
            foreach (var item in collection)
                if (DemSoKyTu(item.name) == TimMaxSoKyTu(collection))
                    dstendai.Add(item.name);
            return dstendai;
        }


        //Tìm tuổi lớn nhất - nhỏ nhất
        public int TimMaxSoTuoi(List<Animal> ds)
        {
            int max = int.MinValue;
            foreach(var item in ds)
                if(max < item.age)
                    max = item.age;
            return max;
        }
        public int TimMinSoTuoi(List<Animal> ds)
        {
            int min = int.MaxValue;
            foreach(var item in ds)
                if(min > item.age)
                    min = item.age;
            return min;
        }
        public List<string> DSDVLonTuoiNhat()
        {
            List<string> ds = new List<string>();
            foreach (var item in collection)
                if (item.age == TimMaxSoTuoi(collection))
                    ds.Add(item.name);
            return ds;
        }
        public List<string> DSDVNhoTuoiNhat()
        {
            List<string> ds = new List<string>();
            foreach(var item in collection)
                if(item.age == TimMinSoTuoi(collection))
                    ds.Add(item.name);
            return ds;
        }
        public void TuoiLonNhat_NhoNhat()
        {
            Console.Write("Cac dv co so tuoi lon nhat la: ");
            XuatList(DSDVLonTuoiNhat());
            Console.Write("Cac dv co so tuoi nho nhat la: ");
            XuatList(DSDVNhoTuoiNhat());
        }

        //ten ngan nhat, dai nhat theo loai
        //public List<Animal> LocDSDVTheoLoai(string loai)
        public List<Animal> LocDSDVTheoLoai(Type loai)
        {
            List<Animal> ds = new List<Animal>();
            foreach (var item in collection)
                //if(item.loai.Trim() == loai)
                if (item.GetType() == loai)
                    ds.Add(item);
            //lấy danh sách trực tiếp từ lớp, thay vì dựa trên thuộc tính loài để xác định
            return ds;
        }
        public List<string> TenDaiNhatTheoLoai(string x)
        {
            List<Animal> ds;
            List<string> dskq = new List<string>();
            if (x == "Lion" || x == "lion")
            {
                ds = LocDSDVTheoLoai(typeof(Lion)); //thay vì lọc như cũ thì đổi thành typeof(Lion) để xác định luôn
                foreach (var item in ds)
                    if (DemSoKyTu(item.name) == TimMaxSoKyTu(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Bat" || x == "bat")
            {
                ds = LocDSDVTheoLoai(typeof(Bat));
                foreach (var item in ds)
                    if (DemSoKyTu(item.name) == TimMaxSoKyTu(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Bird" || x == "bird")
            {
                ds = LocDSDVTheoLoai(typeof(Bird));
                foreach (var item in ds)
                    if(DemSoKyTu(item.name) == TimMaxSoKyTu(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Fish" || x == "fish")
            {
                ds = LocDSDVTheoLoai(typeof(Fish));
                foreach (var item in ds)
                    if(DemSoKyTu(item.name) == TimMaxSoKyTu(ds))
                        dskq.Add(item.name);
            }
            return dskq;
        }

        public List<string> TenNganNhatTheoLoai(string x)
        {
            List<Animal> ds;
            List<string> dskq = new List<string>();
            if (x == "Lion" || x == "lion")
            {
                ds = LocDSDVTheoLoai(typeof(Lion)); //thay vì lọc như cũ thì đổi thành typeof(Lion) để xác định luôn
                foreach (var item in ds)
                    if (DemSoKyTu(item.name) == TimMinSoKyTu(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Bat" || x == "bat")
            {
                ds = LocDSDVTheoLoai(typeof(Bat));
                foreach (var item in ds)
                    if (DemSoKyTu(item.name) == TimMinSoKyTu(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Bird" || x == "bird")
            {
                ds = LocDSDVTheoLoai(typeof(Bird));
                foreach (var item in ds)
                    if (DemSoKyTu(item.name) == TimMinSoKyTu(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Fish" || x == "fish")
            {
                ds = LocDSDVTheoLoai(typeof(Fish));
                foreach (var item in ds)
                    if (DemSoKyTu(item.name) == TimMinSoKyTu(ds))
                        dskq.Add(item.name);
            }
            return dskq;
        }

        //tuoi lon nhat, nho nhat theo loai
        public List<string> TuoiLonNhatTheoLoai(string x)
        {
            List<Animal> ds;
            List<string> dskq = new List<string>();
            if(x == "Lion" || x == "lion")
            {
                ds = LocDSDVTheoLoai(typeof(Lion)); //thay vì lọc như cũ thì đổi thành typeof(Lion) để xác định luôn
                foreach(var item in ds)
                    if(item.age == TimMaxSoTuoi(ds))
                        dskq.Add(item.name);
            }
            else if(x == "Bat" || x == "bat")
            {
                ds = LocDSDVTheoLoai(typeof(Bat));
                foreach (var item in ds)
                    if (item.age == TimMaxSoTuoi(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Bird" || x == "bird")
            {
                ds = LocDSDVTheoLoai(typeof(Bird));
                foreach (var item in ds)
                    if (item.age == TimMaxSoTuoi(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Fish" || x == "fish")
            {
                ds = LocDSDVTheoLoai(typeof(Fish));
                foreach (var item in ds)
                    if (item.age == TimMaxSoTuoi(ds))
                        dskq.Add(item.name);
            }
            return dskq;
        }
        public List<string> TuoiNhoNhatTheoLoai(string x)
        {
            List<Animal> ds;
            List<string> dskq = new List<string>();
            if (x == "Lion" || x == "lion")
            {
                ds = LocDSDVTheoLoai(typeof(Lion));
                foreach (var item in ds)
                    if (item.age == TimMinSoTuoi(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Bat" || x == "bat")
            {
                ds = LocDSDVTheoLoai(typeof(Bat));
                foreach (var item in ds)
                    if (item.age == TimMinSoTuoi(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Bird" || x == "bird")
            {
                ds = LocDSDVTheoLoai(typeof(Bird));
                foreach (var item in ds)
                    if (item.age == TimMinSoTuoi(ds))
                        dskq.Add(item.name);
            }
            else if (x == "Fish" || x == "fish")
            {
                ds = LocDSDVTheoLoai(typeof(Fish));
                foreach (var item in ds)
                    if (item.age == TimMinSoTuoi(ds))
                        dskq.Add(item.name);
            }
            return dskq;
        }
        //Sap xep tang giam theo ten, tuoi
        public void HoanVi(int a, int b, List<Animal>collection)
        {
            Animal temp = collection[a];
            collection[a] = collection[b];
            collection[b] = temp;
        }
        public void SapTangTheoTen()
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if (collection[i].name.CompareTo(collection[j].name) > 0)
                        HoanVi(i, j, collection);
        }
        public void SapGiamTheoTen()
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if (collection[i].name.CompareTo(collection[j].name) < 0)
                        HoanVi(i, j, collection);
        }
        public void SapTangTheoTuoi()
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if (collection[i].age > collection[j].age)
                        HoanVi(i, j, collection);
        }
        public void SapGiamTheoTuoi()
        {
            for (int i = 0; i < collection.Count - 1; i++)
                for (int j = i + 1; j < collection.Count; j++)
                    if (collection[i].age < collection[j].age)
                        HoanVi(i, j, collection);
        }
        public void XoaDVTheoLoai(string x)
        {
            Type loai = Type.GetType("Lab07_KeThuaVaDaKeThua_QuanLyDV_." + x);
            //vì không thể nhập trực tiếp loại Type từ bàn phím nên buộc phải ép về kiểu Type
            //nhưng muốn ép về kiểu Type thì buộc phải có namespace rồi thêm dấu chấm + chuỗi đã nhập
            //bắt buộc chuỗi nhập vào phải giống với tên lớp đó

            //for (int i = 0; i < collection.Count; i++)
            //duyệt xuôi: ds bị dồn lên, các phần tử bị dời lên và sẽ bỏ qua một vài phần tử mà không kiểm tra
            //để sửa sẽ duyệt ngược ds cho an toàn hơn nhiều cách khác
            for (int i = collection.Count-1;i >=0 ; i--)
            {
                if(loai != null && collection[i].GetType() ==  loai)
                    collection.Remove(collection[i]);
            }
        }

        //Xoa dv biet bay, khong biet bay
        public void XoaDVBietBay()
        {
            for(int i = collection.Count-1;i>=0;i--)
                if (collection[i] is IFlyable)
                    collection.Remove(collection[i]);
        }
        public void XoaDVKhongBietBay()
        {
            for (int i = collection.Count - 1; i >= 0; i--)
                if (collection[i] is not IFlyable)
                    collection.Remove(collection[i]);
        }

        //xoa dv biet bay, khong biet bay theo ten
        public void XoaDVBietBayTheoTen(string x)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
                if (collection[i] is IFlyable && collection[i].name == x)
                    collection.Remove(collection[i]);
        }
        public void XoaDVKhongBietBayTheoTen(string x)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
                if (collection[i] is not IFlyable && collection[i].name == x)
                    collection.Remove(collection[i]);
        }

        //xoa dv biet bay, khong biet bay theo tuoi
        public void XoaDVBietBayTheoTuoi(int x)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
                if (collection[i] is IFlyable && collection[i].age == x)
                    collection.Remove(collection[i]);
        }
        public void XoaDVKhongBietBayTheoTuoi(int x)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
                if (collection[i] is not IFlyable && collection[i].age == x)
                    collection.Remove(collection[i]);
        }

        //Xoa dv co tuoi max, min
        public void XoaDVTuoiMax()
        {
            for(int i =collection.Count-1;i>=0;i--)
                if (collection[i].age == TimMaxSoTuoi(collection))
                    collection.Remove(collection[i]);
        }
        public void XoaDVTuoiMin()
        {
            for(int i =collection.Count-1;i>=0;i--)
                if (collection[i].age == TimMinSoTuoi(collection))
                    collection.Remove(collection[i]);
        }

        //Xoa dv theo loai co tuoi max, min
        public void XoaDVTuoiMaxTheoLoai(string x)
        {
            Type loai = Type.GetType("Lab07_KeThuaVaDaKeThua_QuanLyDV_." + x);
            List<Animal> dskq = LocDSDVTheoLoai(loai);
            for (int i = collection.Count - 1; i >= 0; i--)
                if (loai != null && collection[i].GetType() == loai && collection[i].age == TimMaxSoTuoi(dskq))
                    collection.Remove(collection[i]);
        }
        public void XoaDVTuoiMinTheoLoai(string x)
        {
            Type loai = Type.GetType("Lab07_KeThuaVaDaKeThua_QuanLyDV_." + x);
            List<Animal> dskq = LocDSDVTheoLoai(loai);
            for (int i = collection.Count - 1; i >= 0; i--)
                if (loai != null && collection[i].GetType() == loai && collection[i].age == TimMinSoTuoi(dskq))
                    collection.Remove(collection[i]);
        }

        //xoa dv trong ds
        public void XoaDVTrongDS(string name)
        {
            for(int i = collection.Count-1;i>=0;i--)
                if (collection[i].name == name)
                    collection.Remove(collection[i]);
        }
        //Xoa dv tai vi tri x

        //Tinh tong tuoi dv theo loai
        public int TinhTongTuoiTheoLoai(string x)
        {
            Type loai = Type.GetType("Lab07_KeThuaVaDaKeThua_QuanLyDV_." + x);
            int tong = 0;
            foreach(var item in collection)
                if(loai != null && item.GetType() == loai)
                    tong += item.age;
            return tong;
        }
        //Tinh tong tuoi dv biet bay va khong biet bay
        public int TinhTongTuoiDVBietBay()
        {
            int tong = 0;
            foreach (var item in collection)
                if (item is IFlyable)
                    tong += item.age;
            return tong;
        }
        public int TinhTongTuoiDVKhongBietBay()
        {
            int tong = 0;
            foreach (var item in collection)
                if (item is not IFlyable)
                    tong += item.age;
            return tong;
        }
        public void ThemDVVaoViTri(int vt)
        {
            ThemDV(vt);
        }
        public void SapXepGiamDan()
        {

        }
    }
}
