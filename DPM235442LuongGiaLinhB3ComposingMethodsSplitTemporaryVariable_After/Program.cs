using System;

namespace DPM235442LuongGiaLinhB3ComposingMethodsSplitTemporaryVariable_After
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
            // Tách biến tạm thành biến perimeter có ý nghĩa rõ ràng
            double perimeter = 2 * (_height + _width);
            Console.WriteLine($"Chu vi hình chữ nhật: {perimeter}");

            // Tách biến tạm thành biến area riêng biệt
            double area = _height * _width;
            Console.WriteLine($"Diện tích hình chữ nhật: {area}");
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