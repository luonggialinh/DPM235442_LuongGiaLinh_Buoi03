using System;

namespace DPM235442_LuongGiaLinh_RemoveParameter_Before
{
    public class Customer
    {
        public string Name { get; set; }

        // Tham số unusedDate không dùng tới
        public void PrintGreeting(DateTime unusedDate)
        {
            Console.WriteLine($"Xin chào {Name}");
        }
    }

    class Program
    {
        static void Main()
        {
            Customer c = new Customer { Name = "Lương Gia Linh" };
            c.PrintGreeting(DateTime.Now);
        }
    }
}