using System;

namespace DPM235442_LuongGiaLinh_RemoveParameter_Real
{
    public class DiemSo
    {
        public double DiemChuyenCan { get; set; }
        public double DiemThi { get; set; }

        public double TinhDiemTB()
        {
            return (DiemChuyenCan * 0.3) + (DiemThi * 0.7);
        }
    }

    class Program
    {
        static void Main()
        {
            DiemSo ds = new DiemSo { DiemChuyenCan = 9.0, DiemThi = 8.0 };
            Console.WriteLine($"Điểm trung bình: {ds.TinhDiemTB()}");
        }
    }
}