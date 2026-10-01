using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_ExtractClass_Before
{
    public class Person
    {
        public string Name { get; set; }
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }

        public string GetPhoneNumber() => $"({OfficeAreaCode}) {OfficeNumber}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Lương Gia Linh", OfficeAreaCode = "0296", OfficeNumber = "3852111" };
            Console.WriteLine($"{p.Name} - SĐT: {p.GetPhoneNumber()}");
        }
    }
}