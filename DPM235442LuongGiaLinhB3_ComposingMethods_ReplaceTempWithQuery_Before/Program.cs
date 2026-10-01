using System;

namespace DPM235442LuongGiaLinhB3_ComposingMethods_ReplaceTempWithQuery_Before
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

        public double GetPrice()
        {
            double basePrice = _quantity * _itemPrice;
            double discountFactor;
            if (basePrice > 1000)
                discountFactor = 0.95;
            else
                discountFactor = 0.98;

            return basePrice * discountFactor;
        }
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