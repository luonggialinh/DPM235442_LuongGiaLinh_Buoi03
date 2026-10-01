using System;
using System.Collections.Generic;

namespace DPM235442LuongGiaLinh_B3_OrganizingData_ChangeValueToReference_After
{
    public class Customer
    {
        private static Dictionary<string, Customer> _instances = new Dictionary<string, Customer>();

        public string Name { get; }

        private Customer(string name) => Name = name;

        public static Customer Create(string name)
        {
            if (!_instances.ContainsKey(name))
                _instances[name] = new Customer(name);
            return _instances[name];
        }
    }

    class Program
    {
        static void Main()
        {
            Customer c1 = Customer.Create("Công ty An Giang");
            Customer c2 = Customer.Create("Công ty An Giang");
            Console.WriteLine($"Cùng tham chiếu: {object.ReferenceEquals(c1, c2)}");
        }
    }
}