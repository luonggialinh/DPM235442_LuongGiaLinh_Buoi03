using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_InlineClass_Real
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string TenPhongBan { get; set; } // Trực tiếp gộp PhongBan vào NhanVien
        public string MaPhongBan { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien { MaNV = "NV01", HoTen = "Lương Gia Linh", TenPhongBan = "Kế toán" };
            Console.WriteLine($"NV: {nv.HoTen} - Phòng: {nv.TenPhongBan}");
        }
    }
}