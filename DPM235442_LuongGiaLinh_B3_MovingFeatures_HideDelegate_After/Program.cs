using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_ExtractClass_Real
{
    public class DiaChi
    {
        public string SoNha { get; set; }
        public string TenDuong { get; set; }
        public string ThanhPho { get; set; }

        public string GetDiaChiDayDu() => $"{SoNha} {TenDuong}, {ThanhPho}";
    }

    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DiaChi DiaChiThuongTru { get; set; } = new DiaChi();
    }

    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien { MaSV = "DPM235442", HoTen = "Lương Gia Linh" };
            sv.DiaChiThuongTru.SoNha = "123";
            sv.DiaChiThuongTru.TenDuong = "Trần Hưng Đạo";
            sv.DiaChiThuongTru.ThanhPho = "Long Xuyên";

            Console.WriteLine($"SV: {sv.HoTen} - ĐC: {sv.DiaChiThuongTru.GetDiaChiDayDu()}");
        }
    }
}