using System;

namespace DPM235442_LuongGiaLinh_B3_MovingFeatures_HideDelegate_Real
{
    public class LopHoc
    {
        public string GiangVienChuNhiem { get; set; } = "ThS. Trần Văn B";
    }

    public class SinhVien
    {
        private LopHoc _lopHoc = new LopHoc();

        public string GetGiangVien() => _lopHoc.GiangVienChuNhiem;
    }

    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine($"GVCN của sinh viên: {sv.GetGiangVien()}");
        }
    }
}