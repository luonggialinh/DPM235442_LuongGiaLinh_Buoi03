using System;

namespace DPM235442_LuongGiaLinh_GuardClauses_Before
{
    public class Payroll
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired, double basePay)
        {
            double result;
            if (isDead)
            {
                result = 0;
            }
            else
            {
                if (isSeparated)
                {
                    result = 1000;
                }
                else
                {
                    if (isRetired)
                        result = 2000;
                    else
                        result = basePay;
                }
            }
            return result;
        }
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