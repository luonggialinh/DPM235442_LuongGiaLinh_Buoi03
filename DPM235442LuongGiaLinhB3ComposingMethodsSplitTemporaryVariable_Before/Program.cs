using System;

namespace DPM235442LuongGiaLinhB3ComposingMethodsSplitTemporaryVariable_Before
{
    public class Rectangle
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public void PrintGeometry()
        {
            // Dùng chung 1 biến temp cho việc tính Chu vi
            double temp = 2 * (_height + _width);
            Console.WriteLine($"Chu vi hình chữ nhật: {temp}");

            // Tái sử dụng lại biến temp cho việc tính Diện tích (Mã xấu)
            temp = _height * _width;
            Console.WriteLine($"Diện tích hình chữ nhật: {temp}");
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rect = new Rectangle(5, 10);
            rect.PrintGeometry();
        }
    }
}