using System;

namespace DPM235442_LuongGiaLinh_GuardClauses_After
{
    public class Payroll
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired, double basePay)
        {
            if (isDead) return DeadAmount();
            if (isSeparated) return SeparatedAmount();
            if (isRetired) return RetiredAmount();
            return NormalPayAmount(basePay);
        }

        private double DeadAmount() => 0;
        private double SeparatedAmount() => 1000;
        private double RetiredAmount() => 2000;
        private double NormalPayAmount(double basePay) => basePay;
    }

    class Program
    {
        static void Main()
        {
            Payroll p = new Payroll();
            Console.WriteLine($"Lương thực nhận: {p.GetPayAmount(false, false, false, 5000)}");
        }
    }
}