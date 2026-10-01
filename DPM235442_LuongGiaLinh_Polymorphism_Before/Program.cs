using System;

namespace DPM235442_LuongGiaLinh_Polymorphism_Before
{
    public class Employee
    {
        public string Type { get; set; }

        public double GetSpeed()
        {
            switch (Type)
            {
                case "EUROPEAN": return 10;
                case "AFRICAN": return 12;
                default: return 0;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee { Type = "EUROPEAN" };
            Console.WriteLine($"Tốc độ: {emp.GetSpeed()}");
        }
    }
}