using System;

namespace DPM235442_LuongGiaLinh_SeparateQueryFromModifier_Real
{
    public class TaiKhoanNganHang
    {
        public double SoDu { get; private set; } = 5000000;

        public double GetSoDu() => SoDu; // Query

        public void RutTien(double soTien) // Modifier
        {
            if (soTien <= SoDu)
            {
                SoDu -= soTien;
                Console.WriteLine($"Rút thành công {soTien:N0} VNĐ");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            TaiKhoanNganHang tk = new TaiKhoanNganHang();
            Console.WriteLine($"Số dư hiện tại: {tk.GetSoDu():N0} VNĐ");
            tk.RutTien(1000000);
            Console.WriteLine($"Số dư sau rút: {tk.GetSoDu():N0} VNĐ");
        }
    }
}