using System;

namespace DPM235442LuongGiaLinh_B3_ComposingMethods_ReplaceTempWithQuery_Real
{
    public class SanPham
    {
        private double _donGia;
        private int _soLuong;

        public SanPham(double donGia, int soLuong)
        {
            _donGia = donGia;
            _soLuong = soLuong;
        }

        public double TinhThanhTien() => GetBasePrice() * GetDiscountRate();

        private double GetBasePrice() => _donGia * _soLuong;
        private double GetDiscountRate() => GetBasePrice() > 5000000 ? 0.9 : 0.95;
    }

    class Program
    {
        static void Main()
        {
            SanPham sp = new SanPham(2000000, 3);
            Console.WriteLine($"Thành tiền: {sp.TinhThanhTien():N0} VNĐ");
        }
    }
}