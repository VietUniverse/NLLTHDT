namespace LeDuyViet_2411945_Lab8_QuanLyXe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle car1 = new Car("VF9", 400, 6);
            IVehicle motor1 = new Motorcycle("Winner", 200);

            DanhSachPhuongTien vehicles = new DanhSachPhuongTien();

            vehicles.Them(car1);
            vehicles.Them(motor1);

            ((Motorcycle)motor1).TangToc();
            vehicles.Xuat();
        }
    }
}