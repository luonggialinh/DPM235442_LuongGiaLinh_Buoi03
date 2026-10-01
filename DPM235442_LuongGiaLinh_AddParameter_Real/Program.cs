using System;

namespace DPM235442_LuongGiaLinh_AddParameter_Real
{
    public class ThongBaoHocPhi
    {
        // Thực tế: Bổ sung tham số soTien và ngayHan khi gửi thông báo cho sinh viên
        public void GuiThongBao(string maSV, string tenSV, double soTien, DateTime ngayHan)
        {
            Console.WriteLine($"[Thông báo] SV: {tenSV} ({maSV}) - Học phí: {soTien:N0} VNĐ - Hạn nộp: {ngayHan:dd/MM/yyyy}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThongBaoHocPhi tb = new ThongBaoHocPhi();
            tb.GuiThongBao("DPM235442", "Lương Gia Linh", 4500000, new DateTime(2026, 11, 15));
        }
    }
}