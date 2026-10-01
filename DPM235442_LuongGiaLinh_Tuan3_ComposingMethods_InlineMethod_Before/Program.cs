using System;

namespace DPM235442_LuongGiaLinh_Tuan3_ComposingMethods_InlineMethod_Before
{
    public class Order
    {
        private int _numberOfDeliveries = 6;

        public int GetRating() => MoreThanFiveDeliveries() ? 2 : 1;

        private bool MoreThanFiveDeliveries() => _numberOfDeliveries > 5;
    }

    class Program
    {
        static void Main()
        {
            Order o = new Order();
            Console.WriteLine($"Rating: {o.GetRating()}");
        }
    }
}