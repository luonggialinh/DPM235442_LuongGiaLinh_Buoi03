using System;

namespace DPM235442LuongGiaLinh_B3_ComposingMethods_InlineTemp_Before
{
    public class Product
    {
        public double BasePrice() => 500;

        public bool IsPriceAboveThreshold()
        {
            double basePrice = BasePrice();
            return basePrice > 1000;
        }
    }

    class Program
    {
        static void Main()
        {
            Product p = new Product();
            Console.WriteLine($"Vượt ngưỡng: {p.IsPriceAboveThreshold()}");
        }
    }
}