using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_HideDelegate_Before
{
    public class Department
    {
        public string Manager { get; set; }
    }

    public class Person
    {
        public Department Department { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department { Manager = "Nguyễn Văn A" };
            Person p = new Person { Department = dept };

            // Client phải gọi trực tiếp qua Department (Vi phạm Law of Demeter)
            Console.WriteLine($"Trưởng phòng: {p.Department.Manager}");
        }
    }
}