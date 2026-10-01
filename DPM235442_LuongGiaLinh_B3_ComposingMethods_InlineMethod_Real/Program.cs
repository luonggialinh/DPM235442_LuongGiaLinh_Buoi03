using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_InlineMethod_Real
{
    public class SinhVien
    {
        public double DiemTB { get; set; }

        public string XetTotNghiep()
        {
            // Inline kiểm tra trực tiếp
            return DiemTB >= 5.0 ? "Đủ điều kiện tốt nghiệp" : "Chưa đủ điều kiện";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien { DiemTB = 8.2 };
            Console.WriteLine(sv.XetTotNghiep());
        }
    }
}