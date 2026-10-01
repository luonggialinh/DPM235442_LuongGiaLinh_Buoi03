using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_MoveField_Before
{
    public class AccountType { }

    public class Account
    {
        public AccountType Type { get; set; }
        public double InterestRate { get; set; } // Trường này nên thuộc về AccountType
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account { InterestRate = 0.05 };
            Console.WriteLine($"Lãi suất: {acc.InterestRate}");
        }
    }
}