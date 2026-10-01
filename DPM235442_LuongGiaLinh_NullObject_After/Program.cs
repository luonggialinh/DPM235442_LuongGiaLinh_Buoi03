using System;

namespace DPM235442_LuongGiaLinh_NullObject_After
{
    public interface ICustomer
    {
        string Name { get; }
        bool IsNull { get; }
    }

    public class RealCustomer : ICustomer
    {
        public string Name { get; }
        public bool IsNull => false;
        public RealCustomer(string name) => Name = name;
    }

    public class NullCustomer : ICustomer
    {
        public string Name => "Khách hàng vãng lai";
        public bool IsNull => true;
    }

    class Program
    {
        static void Main()
        {
            ICustomer c = new NullCustomer();
            Console.WriteLine($"Tên khách hàng: {c.Name}");
        }
    }
}