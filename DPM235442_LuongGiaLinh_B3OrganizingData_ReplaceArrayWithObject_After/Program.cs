using System;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_ReplaceArrayWithObject_After
{
    public class Performance
    {
        public string Name { get; set; }
        public int Wins { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Performance p = new Performance { Name = "Liverpool", Wins = 15 };
            Console.WriteLine($"Đội: {p.Name}, Số trận thắng: {p.Wins}");
        }
    }
}