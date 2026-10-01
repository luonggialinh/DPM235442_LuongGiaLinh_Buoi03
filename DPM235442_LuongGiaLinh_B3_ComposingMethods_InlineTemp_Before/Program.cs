using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_InlineTemp_Before
{
    public class Order
    {
        public double BasePrice() => 1200;

        public bool IsPriceHigh()
        {
            double basePrice = BasePrice(); // Biến tạm chỉ gán 1 lần rồi trả về
            return basePrice > 1000;
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