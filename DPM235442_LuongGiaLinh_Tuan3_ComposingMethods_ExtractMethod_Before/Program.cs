using System;

namespace DPM235442_LuongGiaLinh_Tuan3_ComposingMethods_ExtractMethod_Before
{
    public class Student
    {
        public void PrintReport(string name, double score)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("--- BÁO CÁO KẾT QUẢ HỌC TẬP ---");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Họ tên: {name}");
            Console.WriteLine($"Điểm: {score}");
        }
    }

    class Program
    {
        static void Main()
        {
            Student s = new Student();
            s.PrintReport("Lương Gia Linh", 9.0);
        }
    }
}