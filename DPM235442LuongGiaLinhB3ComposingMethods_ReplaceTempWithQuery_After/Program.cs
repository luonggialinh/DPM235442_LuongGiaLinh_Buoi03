using System;

namespace DPM235442LuongGiaLinhB3ComposingMethods_ReplaceTempWithQuery_After
{
    public class StudentScore
    {
        private double _midterm;
        private double _final;

        public StudentScore(double midterm, double final)
        {
            _midterm = midterm;
            _final = final;
        }

        public double Total() => AverageScore();

        private double AverageScore() => (_midterm * 0.4) + (_final * 0.6);
    }

    class Program
    {
        static void Main()
        {
            StudentScore sc = new StudentScore(8.5, 9.0);
            Console.WriteLine($"Điểm tổng kết: {sc.Total():N2}");
        }
    }
}