using System;

namespace DPM235442_LuongGiaLinh_RenameMethod_Real
{
    public class QuanLySinhVien
    {
        public double TinhDiemTrungBinhTichLuy(double tongDiem, int tongSoTinChi)
        {
            return tongDiem / tongSoTinChi;
        }
    }

    class Program
    {
        static void Main()
        {
            QuanLySinhVien ql = new QuanLySinhVien();
            Console.WriteLine($"CPA: {ql.TinhDiemTrungBinhTichLuy(320.0, 100):N2}");
        }
    }
}