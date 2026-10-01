using System;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_ReplaceMagicNumber_Real
{
    public class QuanLyHocPhi
    {
        private const double TIEN_TIN_CHI_LY_THUYET = 350000.0;
        private const double TIEN_TIN_CHI_THUC_HANH = 450000.0;

        public double TinhHocPhi(int tinChiLT, int tinChiTH)
        {
            return (tinChiLT * TIEN_TIN_CHI_LY_THUYET) + (tinChiTH * TIEN_TIN_CHI_THUC_HANH);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuanLyHocPhi hp = new QuanLyHocPhi();
            Console.WriteLine($"Học phí: {hp.TinhHocPhi(10, 5):N0} VNĐ");
        }
    }
}