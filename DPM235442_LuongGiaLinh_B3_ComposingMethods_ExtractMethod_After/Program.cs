using System;

namespace DPM235442_LuongGiaLinh_B3_ComposingMethods_ExtractMethod_After
{
    public class OrderProcessor
    {
        public void PrintOutstanding(string name, double outstanding)
        {
            PrintBanner();
            PrintDetails(name, outstanding);
        }

        private void PrintBanner()
        {
            Console.WriteLine("================================");
            Console.WriteLine("====== HOÁ ĐƠN KHÁCH HÀNG ======");
            Console.WriteLine("================================");
        }

        private void PrintDetails(string name, double outstanding)
        {
            Console.WriteLine($"Tên khách hàng: {name}");
            Console.WriteLine($"Số tiền còn nợ: {outstanding:N0} VNĐ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor processor = new OrderProcessor();
            processor.PrintOutstanding("Lương Gia Linh", 1500000);
        }
    }
}