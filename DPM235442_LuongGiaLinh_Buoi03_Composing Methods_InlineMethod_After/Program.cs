using System;

namespace DPM235442_LuongGiaLinh_Buoi03_Composing_Methods_InlineMethod_After
{
    public class Customer
    {
        private int _numberOfOrders;

        public Customer(int numberOfOrders)
        {
            _numberOfOrders = numberOfOrders;
        }

        public bool IsVIP()
        {
            return _numberOfOrders > 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(12);
            Console.WriteLine($"Khách hàng VIP: {c.IsVIP()}");
        }
    }
}S