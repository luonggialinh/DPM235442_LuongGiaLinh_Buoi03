using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_MoveMethod_After
{
    public class AccountType
    {
        public bool IsPremium { get; set; }

        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
                return 10.0 + (daysOverdrawn - 7) * 0.85;
            return daysOverdrawn * 1.75;
        }
    }

    public class Account
    {
        public AccountType Type { get; set; }
        public int DaysOverdrawn { get; set; }

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
                result += Type.OverdraftCharge(DaysOverdrawn);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account { Type = new AccountType { IsPremium = true }, DaysOverdrawn = 10 };
            Console.WriteLine($"Phí ngân hàng: {acc.BankCharge()}");
        }
    }
}