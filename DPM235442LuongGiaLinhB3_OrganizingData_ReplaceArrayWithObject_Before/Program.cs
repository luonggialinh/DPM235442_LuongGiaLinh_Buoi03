using System;

namespace DPM235442LuongGiaLinhB3_OrganizingData_ReplaceArrayWithObject_Before
{
    class Program
    {
        static void Main()
        {
            // Dùng mảng string lưu thông tin hỗn hợp (Dễ sai vị trí index)
            string[] row = new string[3];
            row[0] = "Liverpool";
            row[1] = "15";

            Console.WriteLine($"Tên: {row[0]}, Thắng: {row[1]}");
        }
    }
}