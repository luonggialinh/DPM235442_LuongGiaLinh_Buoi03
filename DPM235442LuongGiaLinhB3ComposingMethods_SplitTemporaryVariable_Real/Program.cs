using System;

namespace DPM235442LuongGiaLinhB3ComposingMethods_SplitTemporaryVariable_Real
{
    public class TransportCalculator
    {
        public double GetTotalDistance(double initialVelocity, double acceleration, double time1, double time2)
        {
            // Giai đoạn 1: Quãng đường chuyển động biến đổi đều (tách biến riêng)
            double primaryDistance = 0.5 * acceleration * time1 * time1;

            // Vận tốc đạt được sau giai đoạn 1
            double secondaryVelocity = initialVelocity + (acceleration * time1);

            // Giai đoạn 2: Quãng đường chuyển động thẳng đều (tách biến riêng)
            double secondaryDistance = secondaryVelocity * time2;

            return primaryDistance + secondaryDistance;
        }
    }

    class Program
    {
        static void Main()
        {
            TransportCalculator calc = new TransportCalculator();
            double totalDistance = calc.GetTotalDistance(10, 2, 5, 10);
            Console.WriteLine($"Tổng quãng đường di chuyển: {totalDistance} m");
        }
    }
}