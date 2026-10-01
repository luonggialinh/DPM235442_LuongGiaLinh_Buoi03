using System;

namespace DPM235442_LuongGiaLinh_Polymorphism_Real
{
    public abstract class SinhVien
    {
        public string HoTen { get; set; }
        public abstract double TinhHocPhi(int soTinChi);
    }

    public class SinhVienChinhQuy : SinhVien
    {
        public override double TinhHocPhi(int soTinChi) => soTinChi * 350000;
    }

    public class SinhVienChatLuongCao : SinhVien
    {
        public override double TinhHocPhi(int soTinChi) => soTinChi * 750000;
    }

    class Program
    {
        static void Main()
        {
            SinhVien sv = new SinhVienChatLuongCao { HoTen = "Lương Gia Linh" };
            Console.WriteLine($"SV: {sv.HoTen} - Học phí: {sv.TinhHocPhi(15):N0} VNĐ");
        }
    }
}