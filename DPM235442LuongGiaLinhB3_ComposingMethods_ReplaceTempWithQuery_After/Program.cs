using System;

namespace DPM235442LuongGiaLinhB3_ComposingMethods_ReplaceTempWithQuery_After
{
    public class Order
    {
        private int _quantity;
        private double _itemPrice;

        public Order(int quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double GetPrice() => BasePrice() * DiscountFactor();

        private double BasePrice() => _quantity * _itemPrice;

        private double DiscountFactor() => BasePrice() > 1000 ? 0.95 : 0.98;
    }

    class Program
    {
        static void Main()
        {
            Order o = new Order(20, 100);
            Console.WriteLine($"Giá: {o.GetPrice()}");
        }
    }
}