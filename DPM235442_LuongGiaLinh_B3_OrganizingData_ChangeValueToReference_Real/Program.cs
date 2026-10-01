using System;
using System.Collections.Generic;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_ChangeValueToReference_Real
{
    public class Customer
    {
        private static Dictionary<string, Customer> _registry = new Dictionary<string, Customer>();

        public string Name { get; private set; }

        private Customer(string name) => Name = name;

        public static void LoadCustomers()
        {
            _registry["Công ty A"] = new Customer("Công ty A");
            _registry["Công ty B"] = new Customer("Công ty B");
        }

        public static Customer GetNamed(string name)
        {
            if (!_registry.ContainsKey(name))
                _registry[name] = new Customer(name);
            return _registry[name];
        }
    }

    public class Order
    {
        public Customer Customer { get; set; }

        public Order(string customerName)
        {
            Customer = Customer.GetNamed(customerName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer.LoadCustomers();
            Order o1 = new Order("Công ty A");
            Order o2 = new Order("Công ty A");

            Console.WriteLine($"Cùng tham chiếu: {object.ReferenceEquals(o1.Customer, o2.Customer)}");
        }
    }
}