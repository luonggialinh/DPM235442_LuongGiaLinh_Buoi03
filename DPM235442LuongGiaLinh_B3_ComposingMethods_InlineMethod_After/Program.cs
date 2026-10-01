using System;

namespace DPM235442LuongGiaLinh_B3_ComposingMethods_InlineMethod_After
{
    public class PizzaOrder
    {
        public int NumberOfPizzas { get; set; } = 3;

        public bool IsLargeOrder()
        {
            return NumberOfPizzas > 5;
        }
    }

    class Program
    {
        static void Main()
        {
            PizzaOrder po = new PizzaOrder();
            Console.WriteLine($"Đơn hàng lớn: {po.IsLargeOrder()}");
        }
    }
}