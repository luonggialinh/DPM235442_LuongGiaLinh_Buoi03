using System;

namespace DPM235442_LuongGiaLinh_Tuan3_ComposingMethods_ExtractMethod_Real
{
    public class QuanLyThuVien
    {
        public void InThongTinMuonSach(string tenSach, string nguoiMuon, int soNgayMuon)
        {
            InTieuDe();
            InChiTiet(tenSach, nguoiMuon, soNgayMuon);
        }

        private void InTieuDe()
        {
            Console.WriteLine("=== PHIẾU MƯỢN SÁCH THƯ VIỆN ===");
        }

        private void InChiTiet(string tenSach, string nguoiMuon, int soNgayMuon)
        {
            Console.WriteLine($"Sách: {tenSach}");
            Console.WriteLine($"Người mượn: {nguoiMuon}");
            Console.WriteLine($"Thời hạn: {soNgayMuon} ngày");
        }
    }

    class Program
    {
        static void Main()
        {
            QuanLyThuVien ql = new QuanLyThuVien();
            ql.InThongTinMuonSach("Design Patterns", "Lương Gia Linh", 14);
        }
    }
}