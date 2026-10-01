using System;

namespace DPM235442LuongGiaLinh_B3_ComposingMethods_InlineTemp_Real
{
    public class VeXemPhim
    {
        public double LayGiaGoc() => 90000;

        public bool IsGiaCao() => LayGiaGoc() > 100000;
    }

    class Program
    {
        static void Main()
        {
            VeXemPhim ve = new VeXemPhim();
            Console.WriteLine($"Giá cao: {ve.IsGiaCao()}");
        }
    }
}