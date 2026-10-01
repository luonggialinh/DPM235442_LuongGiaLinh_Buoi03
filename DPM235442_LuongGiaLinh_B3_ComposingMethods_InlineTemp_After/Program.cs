using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_InlineTemp_After
{
    public class Order
    {
        public double BasePrice() => 1200;

        public bool IsPriceHigh()
        {
            // Bỏ biến tạm không cần thiết
            return BasePrice() > 1000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            Console.WriteLine($"Giá cao: {o.IsPriceHigh()}");
        }
    }
}