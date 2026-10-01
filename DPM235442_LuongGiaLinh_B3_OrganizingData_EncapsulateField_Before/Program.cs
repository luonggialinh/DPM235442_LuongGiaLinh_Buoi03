using System;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_EncapsulateField_Before
{
    public class Person
    {
        public string Name; // Để public trực tiếp (Tránh sử dụng)
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Lương Gia Linh";
            Console.WriteLine($"Tên: {p.Name}");
        }
    }
}