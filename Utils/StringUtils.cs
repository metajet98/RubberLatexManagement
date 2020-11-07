using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMu.Utils
{
    class StringUtils
    {
        public static String FormatThousand(double number)
        {
            if (number.CompareTo(0) == 0) return String.Empty;
            return String.Format("{0:#,###.##}", number);
        }
        public static String FormatThousand(int number)
        {
            if (number.CompareTo(0) == 0) return String.Empty;
            return String.Format("{0:#,###}", number);
        }
    }
}
