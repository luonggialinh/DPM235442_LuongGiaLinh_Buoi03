using System;

namespace DPM235442LuongGiaLinh_B3_ComposingMethods_ExtractVariable_Real
{
    public class LuongNhanVien
    {
        public double TinhThucLinh(double luongCoBan, double heSo, int soGioOt)
        {
            double luongChinh = luongCoBan * heSo;
            double tienOt = soGioOt * 150000;
            return luongChinh + tienOt;
        }
    }

    class Program
    {
        static void Main()
        {
            LuongNhanVien l = new LuongNhanVien();
            Console.WriteLine($"Lương thực lĩnh: {l.TinhThucLinh(5000000, 1.5, 10):N0} VNĐ");
        }
    }
}