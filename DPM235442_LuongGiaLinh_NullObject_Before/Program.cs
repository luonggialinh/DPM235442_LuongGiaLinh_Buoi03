using System;

namespace DPM235442_LuongGiaLinh_NullObject_Real
{
    public interface IDiscount
    {
        double ApplyDiscount(double total);
    }

    public class VIPDiscount : IDiscount
    {
        public double ApplyDiscount(double total) => total * 0.8;
    }

    public class NoDiscount : IDiscount
    {
        public double ApplyDiscount(double total) => total; // Null Object Pattern
    }

    class Program
    {
        static void Main()
        {
            IDiscount discount = new NoDiscount();
            Console.WriteLine($"Tổng tiền sau giảm giá: {discount.ApplyDiscount(1000000):N0} VNĐ");
        }
    }
}