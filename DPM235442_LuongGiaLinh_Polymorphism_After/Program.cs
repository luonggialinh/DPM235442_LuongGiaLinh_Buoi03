using System;

namespace DPM235442_LuongGiaLinh_ParameterizeMethod_Real
{
    public class BanHang
    {
        public double TinhChietKhau(double tongTien, double tyLeChietKhau)
        {
            return tongTien * tyLeChietKhau;
        }
    }

    class Program
    {
        static void Main()
        {
            BanHang bh = new BanHang();
            Console.WriteLine($"Chiết khấu 15%: {bh.TinhChietKhau(2000000, 0.15):N0} VNĐ");
        }
    }
}