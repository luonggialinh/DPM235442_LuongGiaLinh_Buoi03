using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_InlineTemp_Real
{
    public class HocPhiManager
    {
        public double TinhTongTien(int soTinChi) => soTinChi * 350000;

        public bool KiemTraHocPhiLon(int soTinChi)
        {
            return TinhTongTien(soTinChi) > 5000000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HocPhiManager hp = new HocPhiManager();
            Console.WriteLine($"Học phí lớn: {hp.KiemTraHocPhiLon(20)}");
        }
    }
}