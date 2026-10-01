using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_ExtractVariable_Real
{
    public class XetHocBong
    {
        public bool KiemTraKhenThuong(double gpa, int diemRenLuyen, bool viPhamKyLuat)
        {
            bool isGpaDat = gpa >= 3.6;
            bool isRenLuyenDat = diemRenLuyen >= 85;
            bool isKhongViPham = !viPhamKyLuat;

            return isGpaDat && isRenLuyenDat && isKhongViPham;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            XetHocBong xb = new XetHocBong();
            Console.WriteLine($"Đạt học bổng: {xb.KiemTraKhenThuong(3.8, 90, false)}");
        }
    }
}