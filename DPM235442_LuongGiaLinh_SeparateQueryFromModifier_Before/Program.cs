using System;

namespace DPM235442_LuongGiaLinh_SeparateQueryFromModifier_Before
{
    public class Security
    {
        // Hàm vừa kiểm tra vừa bắn cảnh báo (Vi phạm Command Query Separation)
        public string CheckForMiscreantAndSendAlert(string[] people)
        {
            foreach (var p in people)
            {
                if (p == "Don" || p == "John")
                {
                    Console.WriteLine("[Cảnh báo] Phát hiện xâm nhập!");
                    return p;
                }
            }
            return "";
        }
    }

    class Program
    {
        static void Main()
        {
            Security sec = new Security();
            string[] users = { "Alice", "Don" };
            sec.CheckForMiscreantAndSendAlert(users);
        }
    }
}