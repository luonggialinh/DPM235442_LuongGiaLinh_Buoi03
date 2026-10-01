using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_MoveField_Real
{
    public class MonHoc
    {
        public string TenMon { get; set; }
        public int SoTinChi { get; set; } // Chuyển SoTinChi về đúng class MonHoc
    }

    public class SinhVien
    {
        public string MaSV { get; set; }
        public MonHoc MonHocDangKy { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MonHoc mh = new MonHoc { TenMon = "Lập trình C#", SoTinChi = 3 };
            SinhVien sv = new SinhVien { MaSV = "DPM235442", MonHocDangKy = mh };
            Console.WriteLine($"Môn: {sv.MonHocDangKy.TenMon} - SĐT/Tín chỉ: {sv.MonHocDangKy.SoTinChi}");
        }
    }
}