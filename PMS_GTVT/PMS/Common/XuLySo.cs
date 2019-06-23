using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PMS.Common
{
    public static class XuLySo
    {
        /// <summary>
        /// Làm tròn lên cho một số thực
        /// </summary>
        /// <param name="so">Số thực cần làm tròn</param>
        /// <returns> Số nguyên, kết quả sau khi làm tròn </returns>
        public static int LamTronLen(double so)
        {
            return so - (int)so > 0 ? (int)so + 1 : (int)so;
        }

        public static bool KiemTraChuoiToanSo(this string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool KiemTraGioPhut(int strGio, int strPhut)
        {
            bool bchk = false;
            if ((strGio >= 0 && strGio <= 23) && (strPhut >= 0 && strPhut <= 59))
                bchk = true;
            return bchk;
        }


        public static string FormatTime(object valueGioVao, object valueGioRa)
        {
            TimeSpan timeGioVao =TimeSpan.Parse( valueGioVao.ToString());
            TimeSpan timeGioRa = TimeSpan.Parse(valueGioRa.ToString());
            if (timeGioVao == null) return "";
            if (timeGioRa == null) return "";
            TimeSpan timeKQ = timeGioRa - timeGioVao;
            return string.Format("{0:0}:{1:00}", timeKQ.TotalHours, timeKQ.Minutes);
        }

        public static string[] GetLstSplit(string strChuoi,char c)
        {
            return strChuoi.Split(c);
        }

        public static bool CheckTime(string thetime)
        {
            Regex checktime = new Regex("^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            if (!checktime.IsMatch(thetime))
                return false;

            if (thetime.Trim().Length < 5)
                thetime = thetime = "0" + thetime;

            string hh = thetime.Substring(0, 2);
            string mm = thetime.Substring(3, 2);

            int hh_i, mm_i;
            if ((int.TryParse(hh, out hh_i)) && (int.TryParse(mm, out mm_i)))
            {
                if ((hh_i >= 0 && hh_i <= 23) && (mm_i >= 0 && mm_i <= 59))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsTimeString(string ts)
        {
            if (ts.Length == 5 && ts.Contains(':'))
            {
                int h;
                int m;

                return int.TryParse(ts.Substring(0, 2), out h) &&
                       int.TryParse(ts.Substring(3, 2), out m) &&
                       h >= 0 && h < 24 &&
                       m >= 0 && m < 60;
            }
            else
                return false;
        }
    }
}
