using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_ExtractClass_After
{
    public class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public string GetFullPhoneNumber() => $"({AreaCode}) {Number}";
    }

    public class Person
    {
        public string Name { get; set; }
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Lương Gia Linh" };
            p.Phone.AreaCode = "0296";
            p.Phone.Number = "3852111";
            Console.WriteLine($"{p.Name} - SĐT: {p.Phone.GetFullPhoneNumber()}");
        }
    }
}