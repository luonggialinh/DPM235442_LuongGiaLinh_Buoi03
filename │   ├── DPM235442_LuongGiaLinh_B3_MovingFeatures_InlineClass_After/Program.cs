using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_InlineClass_After
{
    public class Person
    {
        public string Name { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public string GetPhoneNumber() => $"({AreaCode}) {Number}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Lương Gia Linh", AreaCode = "0296", Number = "3852111" };
            Console.WriteLine($"{p.Name} - SĐT: {p.GetPhoneNumber()}");
        }
    }
}