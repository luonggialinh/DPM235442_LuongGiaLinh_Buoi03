using System;

namespace DPM235442_LuongGiaLinh_RenameMethod_After
{
    public class Person
    {
        private string _officeAreaCode = "0296";
        private string _officeNumber = "3852111";

        // Tên phương thức rõ ràng
        public string GetOfficePhoneNumber() => $"({_officeAreaCode}) {_officeNumber}";
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person();
            Console.WriteLine($"SĐT văn phòng: {p.GetOfficePhoneNumber()}");
        }
    }
}