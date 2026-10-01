using System;
sing System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_ReplaceTempWithQuery_Real
{
    public class HoaDonTienDien
    {
        private int _soKwh;
        private double _donGia;

        public HoaDonTienDien(int soKwh, double donGia)
        {
            _soKwh = soKwh;
            _donGia = donGia;
        }

        public double TinhThanhTien()
        {
            return GetBasePrice() * GetDiscountFactor();
        }

        private double GetBasePrice() => _soKwh * _donGia;

        private double GetDiscountFactor() => GetBasePrice() > 1000000 ? 0.95 : 0.98;
    }

    class Program
    {
        static void Main(string[] args)
        {
            HoaDonTienDien hd = new HoaDonTienDien(500, 3000);
            Console.WriteLine($"Thành tiền: {hd.TinhThanhTien():N0} VNĐ");
        }
    }
}