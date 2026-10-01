using System;

namespace DPM235442_LuongGiaLinh_RenameMethod_Before
{
    public class Person
    {
        private string _officeAreaCode = "0296";
        private string _officeNumber = "3852111";

        // Tên phương thức quá chung chung
        public string GetPhone() => $"({_officeAreaCode}) {_officeNumber}";
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person();
            Console.WriteLine($"SĐT: {p.GetPhone()}");
        }
    }
}