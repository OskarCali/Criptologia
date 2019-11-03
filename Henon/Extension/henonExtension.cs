using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henon
{
    static class henonExtension
    {
        public static string ToBin(this string text, Encoding encoding)
        {
            return String.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }

        public static string ToText(this string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
}
