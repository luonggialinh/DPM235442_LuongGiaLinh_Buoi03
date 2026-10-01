using System;

namespace DPM235442LuongGiaLinhB3_OrganizingData_ChangeValueToReference_Before
{
    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name) => Name = name;
    }

    class Program
    {
        static void Main()
        {
            Customer c1 = new Customer("Công ty An Giang");
            Customer c2 = new Customer("Công ty An Giang");
            Console.WriteLine($"Cùng tham chiếu: {object.ReferenceEquals(c1, c2)}");
        }
    }
}