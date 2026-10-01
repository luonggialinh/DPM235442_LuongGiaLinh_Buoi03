using System;

namespace DPM235442_LuongGiaLinh_AddParameter_Before
{
    public class Customer
    {
        // Trước khi Refactor: Thiếu tham số thông tin ngày sinh
        public void GetContact(string name)
        {
            Console.WriteLine($"Tên khách hàng: {name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GetContact("Lương Gia Linh");
        }
    }
}