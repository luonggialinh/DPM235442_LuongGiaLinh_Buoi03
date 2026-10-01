using System;

namespace DPM235442_LuongGiaLinh_ReplaceTypeCodeWithSubclasses_Before
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;

        public int Type { get; set; }

        public Employee(int type) => Type = type;
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee(Employee.ENGINEER);
            Console.WriteLine($"Loại: {emp.Type}");
        }
    }
}