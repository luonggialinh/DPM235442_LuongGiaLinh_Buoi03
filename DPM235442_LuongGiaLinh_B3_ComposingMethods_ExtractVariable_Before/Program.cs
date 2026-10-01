using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_ExtractVariable_Before
{
    public class Order
    {
        public double CalculatePrice(int quantity, double itemPrice)
        {
            // Biểu thức phức tạp, khó đọc
            return quantity * itemPrice - Math.Max(0, quantity - 500) * itemPrice * 0.05 + Math.Min(quantity * itemPrice * 0.1, 100.0);
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