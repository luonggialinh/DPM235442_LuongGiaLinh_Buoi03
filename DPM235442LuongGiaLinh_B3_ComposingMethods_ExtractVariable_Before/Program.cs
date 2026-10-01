using System;

namespace DPM235442LuongGiaLinh_B3_ComposingMethods_ExtractVariable_Before
{
    public class Calculator
    {
        public double Compute(double price, int quantity)
        {
            return (price * quantity) - (Math.Max(0, quantity - 10) * price * 0.1);
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