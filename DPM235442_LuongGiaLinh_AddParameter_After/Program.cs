using System;

namespace DPM235442_LuongGiaLinh_AddParameter_After
{
    public class Customer
    {
        // Sau khi Refactor: Bổ sung tham số dateOfBirth cần thiết
        public void GetContact(string name, DateTime dateOfBirth)
        {
            Console.WriteLine($"Tên khách hàng: {name}, Ngày sinh: {dateOfBirth:dd/MM/yyyy}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GetContact("Lương Gia Linh", new DateTime(2003, 5, 20));
        }
    }
}