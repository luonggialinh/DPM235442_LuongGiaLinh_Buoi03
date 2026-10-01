using System;

namespace DPM235442LuongGiaLinh_B3_ComposingMethods_ExtractVariable_After
{
    public class Calculator
    {
        public double Compute(double price, int quantity)
        {
            double basePrice = price * quantity;
            double discount = Math.Max(0, quantity - 10) * price * 0.1;
            return basePrice - discount;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator c = new Calculator();
            Console.WriteLine($"Tổng tiền: {c.Compute(100, 15)}");
        }
    }
}