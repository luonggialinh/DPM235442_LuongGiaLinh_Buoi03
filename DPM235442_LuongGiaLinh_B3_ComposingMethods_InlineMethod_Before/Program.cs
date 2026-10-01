using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_InlineMethod_Before
{
    public class Driver
    {
        private int _numberOfLateDeliveries;

        public Driver(int numberOfLateDeliveries)
        {
            _numberOfLateDeliveries = numberOfLateDeliveries;
        }

        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        // Phương thức quá đơn giản gây dư thừa
        private bool MoreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Driver d = new Driver(6);
            Console.WriteLine($"Xếp loại: {d.GetRating()}");
        }
    }
}