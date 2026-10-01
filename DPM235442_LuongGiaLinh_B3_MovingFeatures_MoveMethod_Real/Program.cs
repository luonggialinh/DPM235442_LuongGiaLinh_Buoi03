using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_MoveMethod_Real
{
    public class MonHoc
    {
        public string TenMon { get; set; }
        public double DiemChuyenCan { get; set; }
        public double DiemThi { get; set; }

        // Chuyển hàm tính điểm về đúng class MonHoc
        public double TinhDiemTongKet() => (DiemChuyenCan * 0.3) + (DiemThi * 0.7);
    }

    class Program
    {
        static void Main(string[] args)
        {
            MonHoc mh = new MonHoc { TenMon = "Kiến trúc phần mềm", DiemChuyenCan = 9.0, DiemThi = 8.5 };
            Console.WriteLine($"Điểm tổng kết môn {mh.TenMon}: {mh.TinhDiemTongKet():N2}");
        }
    }
}