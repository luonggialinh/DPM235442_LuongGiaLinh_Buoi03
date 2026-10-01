using System;

namespace DPM235442_LuongGiaLinh_ReplaceTypeCodeWithSubclasses_After
{
    public abstract class Employee
    {
        public abstract int GetTypeCode();
    }

    public class Engineer : Employee
    {
        public override int GetTypeCode() => 0;
    }

    public class Salesman : Employee
    {
        public override int GetTypeCode() => 1;
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Engineer();
            Console.WriteLine($"Mã loại nhân viên: {emp.GetTypeCode()}");
        }
    }
}