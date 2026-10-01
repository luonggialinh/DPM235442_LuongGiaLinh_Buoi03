using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_ExtractVariable_After
{
    public class Order
    {
        public double CalculatePrice(int quantity, double itemPrice)
        {
            // Tách các biến tạm rõ nghĩa
            double basePrice = quantity * itemPrice;
            double quantityDiscount = Math.Max(0, quantity - 500) * itemPrice * 0.05;
            double shipping = Math.Min(basePrice * 0.1, 100.0);

            return basePrice - quantityDiscount + shipping;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            Console.WriteLine($"Tổng tiền: {order.CalculatePrice(600, 20)}");
        }
    }
}