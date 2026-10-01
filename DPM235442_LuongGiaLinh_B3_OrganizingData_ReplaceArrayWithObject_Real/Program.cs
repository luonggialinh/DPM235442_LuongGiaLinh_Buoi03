using System;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_ReplaceArrayWithObject_Real
{
    public class BangDiem
    {
        public string TenMon { get; set; }
        public double DiemGiuaKy { get; set; }
        public double DiemCuoiKy { get; set; }

        public double TinhTrungBinh() => (DiemGiuaKy + DiemCuoiKy) / 2;
    }

    class Program
    {
        static void Main(string[] args)
        {
            BangDiem bd = new BangDiem { TenMon = "Thiết kế phần mềm", DiemGiuaKy = 8.0, DiemCuoiKy = 9.0 };
            Console.WriteLine($"Môn: {bd.TenMon} - ĐTB: {bd.TinhTrungBinh():N1}");
        }
    }
}