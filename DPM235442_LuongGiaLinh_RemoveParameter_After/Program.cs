using System;

namespace DPM235442_LuongGiaLinh_RemoveParameter_After
{
    public class Customer
    {
        public string Name { get; set; }

        // Bỏ tham số thừa
        public void PrintGreeting()
        {
            Console.WriteLine($"Xin chào {Name}");
        }
    }

    class Program
    {
        static void Main()
        {
            Customer c = new Customer { Name = "Lương Gia Linh" };
            c.PrintGreeting();
        }
    }
}