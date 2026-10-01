using System;

namespace DPM235442_LuongGiaLinh_ParameterizeMethod_After
{
    public class Employee
    {
        public double Salary { get; set; } = 1000;

        // Tham số hoá phương thức
        public void RaiseSalary(double factor)
        {
            Salary *= (1 + factor);
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.RaiseSalary(0.10);
            Console.WriteLine($"Lương sau tăng: {emp.Salary}");
        }
    }
}