using System;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_EncapsulateField_After
{
    public class Person
    {
        private string _name;

        // Đã đóng gói trường dữ liệu
        public string Name
        {
            get => _name;
            set => _name = value;
        }
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