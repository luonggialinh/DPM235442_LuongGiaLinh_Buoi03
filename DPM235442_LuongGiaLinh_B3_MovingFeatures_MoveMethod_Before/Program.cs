using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_MoveMethod_Before
{
    public class AccountType
    {
        public bool IsPremium { get; set; }
    }

    public class Account
    {
        public AccountType Type { get; set; }
        public int DaysOverdrawn { get; set; }

        // OverdraftCharge dùng thuộc tính của AccountType nhiều hơn Account
        public double OverdraftCharge()
        {
            if (Type.IsPremium)
                return 10.0 + (DaysOverdrawn - 7) * 0.85;
            return DaysOverdrawn * 1.75;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account { Type = new AccountType { IsPremium = true }, DaysOverdrawn = 10 };
            Console.WriteLine($"Phí thấu chi: {acc.OverdraftCharge()}");
        }
    }
}