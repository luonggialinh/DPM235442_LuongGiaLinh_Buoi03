using System;

namespace DPM235442LuongGiaLinh_B3_ComposingMethods_InlineMethod_Real
{
    public class KiemTraDiem
    {
        public bool IsQuaMon(double diem) => diem >= 5.0;
    }

    class Program
    {
        static void Main()
        {
            KiemTraDiem kt = new KiemTraDiem();
            Console.WriteLine($"Kết quả qua môn: {kt.IsQuaMon(7.5)}");
        }
    }
}