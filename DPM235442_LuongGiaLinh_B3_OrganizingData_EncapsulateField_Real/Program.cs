using System;

namespace DPM235442_LuongGiaLinh_B3_OrganizingData_EncapsulateField_Real
{
    public class SinhVien
    {
        private string _maSV;
        private double _diemTB;

        public string MaSV
        {
            get => _maSV;
            set => _maSV = value ?? string.Empty;
        }

        public double DiemTB
        {
            get => _diemTB;
            set => _diemTB = Math.Clamp(value, 0.0, 10.0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien { MaSV = "DPM235442", DiemTB = 11.5 }; // Tự động giới hạn về 10
            Console.WriteLine($"SV: {sv.MaSV} - Điểm: {sv.DiemTB}");
        }
    }
}