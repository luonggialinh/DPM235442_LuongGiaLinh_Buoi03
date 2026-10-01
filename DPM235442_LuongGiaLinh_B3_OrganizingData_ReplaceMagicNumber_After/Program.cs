using System;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_ReplaceMagicNumber_After
{
    public class Physics
    {
        private const double GRAVITATIONAL_CONSTANT = 9.81;

        public double PotentialEnergy(double mass, double height)
        {
            return mass * height * GRAVITATIONAL_CONSTANT;
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