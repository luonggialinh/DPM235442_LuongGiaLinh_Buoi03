using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_MoveField_After
{
    public class AccountType
    {
        public double InterestRate { get; set; }
    }

    public class Account
    {
        public AccountType Type { get; set; }

        public double InterestRate => Type.InterestRate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            AccountType type = new AccountType { InterestRate = 0.05 };
            Account acc = new Account { Type = type };
            Console.WriteLine($"Lãi suất: {acc.InterestRate}");
        }
    }
}