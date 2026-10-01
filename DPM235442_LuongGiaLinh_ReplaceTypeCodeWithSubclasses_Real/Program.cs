using System;

namespace DPM235442_LuongGiaLinh_ReplaceTypeCodeWithSubclasses_Real
{
    public abstract class NhanVien
    {
        public string HoTen { get; set; }
        public abstract double TinhPhuCap();
    }

    public class NhanVienChinhThuc : NhanVien
    {
        public override double TinhPhuCap() => 2000000;
    }

    public class NhanVienThucTap : NhanVien
    {
        public override double TinhPhuCap() => 500000;
    }

    class Program
    {
        static void Main()
        {
            NhanVien nv = new NhanVienChinhThuc { HoTen = "Lương Gia Linh" };
            Console.WriteLine($"NV: {nv.HoTen} - Phụ cấp: {nv.TinhPhuCap():N0} VNĐ");
        }
    }
}