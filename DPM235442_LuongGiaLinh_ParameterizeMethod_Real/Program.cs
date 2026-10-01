using System;

namespace DPM235442_LuongGiaLinh_ParameterizeMethod_Before
{
    public class Employee
    {
        public double Salary { get; set; } = 1000;

        public void TenPercentRaise() => Salary *= 1.10;
        public void FivePercentRaise() => Salary *= 1.05;
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.TenPercentRaise();
            Console.WriteLine($"Lương sau tăng: {emp.Salary}");
        }
    }
}