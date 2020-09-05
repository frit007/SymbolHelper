using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolHelper.Helpers {
    class UTF8Helper {
        // might throw an exception
        public static string hexStringToLetter(String hexString) {
            int intValue = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("readLeter: " + intValue);
            if (intValue > 0xff0000) {
                return Encoding.UTF8.GetString(new byte[] { (byte)((intValue & 0xFF000000) >> 24), (byte)((intValue & 0xFF0000) >> 16), (byte)((intValue & 0xFF00) >> 8), (byte)(intValue & 0x00FF) });
            } else if (intValue > 0xff00) {
                return Encoding.UTF8.GetString(new byte[] { (byte)((intValue & 0xFF0000) >> 16), (byte)((intValue & 0xFF00) >> 8), (byte)(intValue & 0x00FF) });
            } else if (intValue > 0xff) {
                return Encoding.UTF8.GetString(new byte[] { (byte)((intValue & 0xFF00) >> 8), (byte)(intValue & 0x00FF) });
            } else {
                return Encoding.UTF8.GetString(new byte[] { (byte)(intValue & 0x00FF) });
            }
        }
    }
}
