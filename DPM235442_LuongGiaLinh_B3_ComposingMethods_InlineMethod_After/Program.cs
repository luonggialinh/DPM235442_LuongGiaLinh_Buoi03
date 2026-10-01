using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_InlineMethod_After
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
            // Inline điều kiện trực tiếp vào hàm
            return _numberOfLateDeliveries > 5 ? 2 : 1;
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