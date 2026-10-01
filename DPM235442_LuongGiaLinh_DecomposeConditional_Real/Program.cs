using System;

namespace DPM235442_LuongGiaLinh_DecomposeConditional_Real
{
    public class TinhTienDien
    {
        private static readonly DateTime SUMMER_START = new DateTime(2026, 6, 1);
        private static readonly DateTime SUMMER_END = new DateTime(2026, 8, 31);

        public double TinhTien(DateTime date, double quantity, double summerRate, double winterRate, double winterServiceCharge)
        {
            if (IsSummer(date))
                return SummerCharge(quantity, summerRate);
            else
                return WinterCharge(quantity, winterRate, winterServiceCharge);
        }

        private bool IsSummer(DateTime date) => date >= SUMMER_START && date <= SUMMER_END;
        private double SummerCharge(double quantity, double rate) => quantity * rate;
        private double WinterCharge(double quantity, double rate, double serviceCharge) => (quantity * rate) + serviceCharge;
    }

    class Program
    {
        static void Main()
        {
            TinhTienDien td = new TinhTienDien();
            Console.WriteLine($"Tiền điện mùa hè: {td.TinhTien(new DateTime(2026, 7, 15), 100, 3000, 2500, 50000):N0} VNĐ");
        }
    }
}