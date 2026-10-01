using System;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_ReplaceMagicNumber_Before
{
    public class Physics
    {
        public double PotentialEnergy(double mass, double height)
        {
            return mass * height * 9.81; // 9.81 là Magic Number
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Physics p = new Physics();
            Console.WriteLine($"Thế năng: {p.PotentialEnergy(10, 5)}");
        }
    }
}