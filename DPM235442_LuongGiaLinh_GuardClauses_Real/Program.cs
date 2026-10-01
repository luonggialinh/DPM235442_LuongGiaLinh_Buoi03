using System;

namespace DPM235442_LuongGiaLinh_GuardClauses_Real
{
    public class XetThi
    {
        public string KiemTraDieuKienThi(bool daDongHocPhi, int soBuoiVang, double diemChuyenCan)
        {
            if (!daDongHocPhi) return "Không đủ điều kiện: Chưa đóng học phí";
            if (soBuoiVang > 3) return "Không đủ điều kiện: Vắng quá 3 buổi";
            if (diemChuyenCan < 5.0) return "Không đủ điều kiện: Điểm chuyên cần dưới 5";

            return "Đủ điều kiện tham gia thi kết thúc học phần";
        }
    }

    class Program
    {
        static void Main()
        {
            XetThi xt = new XetThi();
            Console.WriteLine(xt.KiemTraDieuKienThi(true, 1, 8.5));
        }
    }
}